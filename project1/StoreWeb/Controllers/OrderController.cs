using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using StoreWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using NpgsqlTypes;

namespace StoreWeb.Controllers
{
    public class OrderController : Controller
    {
        //TODO url proper needed
        const string url = "https://localhost:44317/";
        private User user;
        public IActionResult Receipt(Order order)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var response = client.GetAsync($"order/get/{order.OrderId}");
                response.Wait();

                if (response.Result.IsSuccessStatusCode)
                {
                    var result = response.Result.Content.ReadAsStringAsync();
                    var model = JsonConvert.DeserializeObject<Order>(result.Result);
                    return View(model);
                }
                return RedirectToAction("GetInventory", "Customer");
            }
        }
        public IActionResult AddOrder(Cart cart)
        {
            user = HttpContext.Session.GetObject<User>("User");
            if (user == null)
                return RedirectToAction("Login", "Home");

            if (ModelState.IsValid)
            {
                Order order = new Order();
                order.TotalCost = cart.TotalCost;
                order.LocationId = user.LocationId;
                order.OrderDate = DateTime.Now;
                NpgsqlDateTime npgsqlDateTime = order.OrderDate;
                order.UserId = user.UserId;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);

                    var json = JsonConvert.SerializeObject(order);
                    var data = new StringContent(json, Encoding.UTF8, "application/json");

                    var response = client.PostAsync("order/add", data);
                    response.Wait();

                    while (response.Result.IsSuccessStatusCode)
                    {
                        // Added new order successfully
                        // Now get order we just added to map orderId
                        response = client.GetAsync($"order/get?dateTime={npgsqlDateTime}");
                        response.Wait();
                        var result = response.Result.Content.ReadAsStringAsync();
                        var newOrder = JsonConvert.DeserializeObject<Order>(result.Result);

                        // Got order back successfully
                        order.OrderId = newOrder.OrderId;
                        foreach (var item in user.Cart.CartItems)
                        {
                            Product product = item.Product;
                            LineItem lineItem = new LineItem();
                            lineItem.OrderId = order.OrderId;
                            lineItem.ProductId = item.ProductId;
                            lineItem.Price = product.Price;
                            lineItem.Quantity = item.Quantity;

                            // Serialize LineItem object and add to db using POST method
                            json = JsonConvert.SerializeObject(lineItem);
                            data = new StringContent(json, Encoding.UTF8, "application/json");
                            response = client.PostAsync("lineitem/add", data);
                            response.Wait();

                            // Added new line item successfully
                            // Get inventory item and update quantity
                            response = client.GetAsync($"inventoryitem/get/{user.LocationId}/{item.ProductId}");
                            response.Wait();
                            result = response.Result.Content.ReadAsStringAsync();
                            var inventoryItem = JsonConvert.DeserializeObject<Inventory>(result.Result);
                            inventoryItem.Quantity -= item.Quantity;

                            json = JsonConvert.SerializeObject(inventoryItem);
                            data = new StringContent(json, Encoding.UTF8, "application/json");
                            response = client.PutAsync("inventoryitem/update", data);
                            response.Wait();
                        }

                        // Clear cart items and redirect to receipt view
                        user.Cart.CartItems.Clear();
                        HttpContext.Session.SetObject("User", user);
                        return RedirectToAction("Receipt", order);
                    }
                }
            }
            return RedirectToAction("GetInventory", "Customer");
        }
        public IActionResult GetOrderHistory(string sort)
        {
            ViewBag.CostSortParm = sort == "cost_asc" ? "cost_asc" : "cost_desc";
            ViewBag.DateSortParm = sort == "date_asc" ? "date_asc" : "date_desc";
            ViewBag.SortOptions = new List<SelectListItem>()
            {
                new SelectListItem { Selected = false, Text = "Price (Lowest to Highest)", Value = ("cost_asc")},
                new SelectListItem { Selected = false, Text = "Price (Highest to Lowest)", Value = ("cost_desc")},
                new SelectListItem { Selected = false, Text = "Date (Lowest to Highest)", Value = ("date_asc")},
                new SelectListItem { Selected = false, Text = "Date (Highest to Lowest)", Value = ("date_asc")}
            };
            // Get User
            user = HttpContext.Session.GetObject<User>("User");
            if (user == null)
                return RedirectToAction("Login", "Home");
            if (user.Type == StoreWeb.Models.User.UserType.Customer)
            {
                // Get order history
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    var response = client.GetAsync($"order/get/user?id={user.UserId}");
                    response.Wait();

                    if (response.Result.IsSuccessStatusCode)
                    {
                        var result = response.Result.Content.ReadAsStringAsync();
                        var model = JsonConvert.DeserializeObject<List<Order>>(result.Result)
                            .OrderBy(x => x.OrderId);
                        switch (sort)
                        {
                            case "cost_asc":
                                model = JsonConvert.DeserializeObject<List<Order>>(result.Result)
                                    .OrderBy(x => x.TotalCost);
                                break;
                            case "cost_desc":
                                model = JsonConvert.DeserializeObject<List<Order>>(result.Result)
                                    .OrderByDescending(x => x.TotalCost);
                                break;
                            case "date_asc":
                                model = JsonConvert.DeserializeObject<List<Order>>(result.Result)
                                    .OrderBy(x => x.OrderDate);
                                break;
                            case "date_desc":
                                model = JsonConvert.DeserializeObject<List<Order>>(result.Result)
                                    .OrderByDescending(x => x.OrderDate);
                                break;
                            default:
                                break;
                        }
                        return View(model);
                    }
                    return RedirectToAction("GetInventory", "Customer");
                }
            }
            return RedirectToAction("GetInventory", "Customer");
        }
    }
}