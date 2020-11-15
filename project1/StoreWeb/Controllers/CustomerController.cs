using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using StoreWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace GGsWeb.Controllers
{
    public class CustomerController : Controller
    {
        const string url = "https://localhost:44317/";
        private User user;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetInventory()
        {
            user = HttpContext.Session.GetObject<User>("User");
            if (user == null)
                return RedirectToAction("Login", "Home");
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    var response = client.GetAsync($"inventoryitem/get/{user.LocationId}");
                    response.Wait();

                    var result = response.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var jsonString = result.Content.ReadAsStringAsync();
                        jsonString.Wait();

                        var model = JsonConvert.DeserializeObject<List<Inventory>>(jsonString.Result);
                        return View(model);
                    }
                }
            }
            return View();
        }
        public IActionResult AddItemToCart(int productId, int quantity)
        {
            Product product = new Product();
            user = HttpContext.Session.GetObject<User>("User");
            if (user == null)
                return RedirectToAction("Login", "Home");
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var response = client.GetAsync($"product/get?id={productId}");
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var jsonString = result.Content.ReadAsStringAsync();
                    jsonString.Wait();
                    var prod = JsonConvert.DeserializeObject<Product>(jsonString.Result);
                    product = prod;
                }
            }
            CartItem item = new CartItem()
            {
                ProductId = productId,
                Product = product,
                Quantity = quantity
            };
            user.Cart.TotalCost += (product.Price * quantity);
            user.Cart.CartItems.Add(item);
            HttpContext.Session.SetObject("User", user);
            return View("GetInventory", user.Location.Inventory);
        }
        public IActionResult RemoveItemFromCart(Product product)
        {
            user = HttpContext.Session.GetObject<User>("User");
            if (user == null)
                return RedirectToAction("Login", "Home");
            CartItem item = new CartItem()
            {
                ProductId = product.ProductId,
                Product = product,
                Quantity = 1
            };
            user.Cart.CartItems.RemoveAll(x => x.ProductId == item.ProductId);
            user.Cart.TotalCost -= (product.Price * item.Quantity);
            HttpContext.Session.SetObject("User", user);
            return RedirectToAction("GetCart");
        }
        public IActionResult GetCart()
        {
            user = HttpContext.Session.GetObject<User>("User");
            if (user == null)
                return RedirectToAction("Login", "Home");
            return View(user.Cart);
        }
        [HttpGet]
        public IActionResult EditUser()
        {
            user = HttpContext.Session.GetObject<User>("User");
            if (user == null)
                return RedirectToAction("Login", "Home");
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var response = client.GetAsync("location/getAll");
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var jsonString = result.Content.ReadAsStringAsync();
                    jsonString.Wait();
                    var locations = JsonConvert.DeserializeObject<List<Location>>(jsonString.Result);
                    var locationOptions = new List<SelectListItem>();
                    foreach (var loc in locations)
                    {
                        locationOptions.Add(new SelectListItem { Selected = false, Text = $"{loc.City}, {loc.State}", 
                            Value = loc.LocationId.ToString() });
                    }
                    ViewBag.locationOptions = locationOptions;
                }
            }
            return View(user);
        }
        [HttpPost]
        public IActionResult EditUser(User newUser)
        {
            user = HttpContext.Session.GetObject<User>("User");
            if (user == null)
                return RedirectToAction("Login", "Home");

            // Map newUser values
            // User decided not to update password, keep it the same
            if (newUser.Password == null)
                newUser.Password = user.Password;
            newUser.Location = user.Location;
            newUser.Orders = user.Orders;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var json = JsonConvert.SerializeObject(newUser);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PutAsync("user/update", data);
                response.Wait();
                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    // Successfully edited user
                    HttpContext.Session.SetObject("User", newUser);
                    return View(newUser);
                }
            }
            return View("GetInventory");
        }
    }
}