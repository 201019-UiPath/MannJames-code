using System;
using System.Collections.Generic;
using System.Net.Http;
using StoreWeb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace StoreWeb.Controllers
{
    public class CustomerController : Controller
    {
        //TODO put url in
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
                    var response = client.GetAsync($"inventory/get/{user.LocationId}");
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
        public IActionResult AddItemToCart(Product product)
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
            user.Cart.TotalCost += (product.Price * item.Quantity);
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
            return RedirectToAction("ViewCart");
        }
        public IActionResult AddCustomer()
        {
            return View();
        }

        public IActionResult GetCart()
        {
            user = HttpContext.Session.GetObject<User>("User");
            if (user == null)
                return RedirectToAction("Login", "Home");
            return View(user.Cart);
        }
    }
}