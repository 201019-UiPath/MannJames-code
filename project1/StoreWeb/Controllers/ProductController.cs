using System;
using System.Net.Http;
using StoreWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace StoreWeb.Controllers
{
    public class ProductController : Controller
    {
        //TODO get the url (44331 for web project but not sure for other project)
        const string url = "";
        private User user;
        public IActionResult Details(int productId)
        {
            user = HttpContext.Session.GetObject<User>("User");
            if (user == null)
                return RedirectToAction("Login", "Home");
            if (ModelState.IsValid)
            {
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

                        var model = JsonConvert.DeserializeObject<Product>(jsonString.Result);
                        return View(model);
                    }
                }
            }
            return View();
        }
    }
}