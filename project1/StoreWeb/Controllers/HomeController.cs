using System;
using System.Collections.Generic;
using System.Net.Http;
using StoreWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace StoreWeb.Controllers
{
    public class HomeController : Controller
    {
        readonly HttpClient client = new HttpClient();
        private const string url = "https://localhost:44317/";
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public async Task<ViewResult> Login()
        {
            var model = new LoginModel();
            //await model;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            HttpClientHandler handler = new HttpClientHandler();
            var client = new HttpClient(handler);
            client.BaseAddress = new Uri(url);
            var response = client.GetAsync($"user/get/name={model.Username}");
            await response;
            //problem is here in debug
            if (response.Result.IsSuccessStatusCode)
            {
                var jsonString = response.Result.Content.ReadAsStringAsync();
                await jsonString;
                var verifiedUser = JsonConvert.DeserializeObject<User>(jsonString.Result);
                if (verifiedUser.Password == model.Password && verifiedUser.Username == model.Username)
                {
                    HttpContext.Session.SetObject("User", verifiedUser);
                    return RedirectToAction("GetInventory", "Customer");
                }
                else
                {
                    ModelState.AddModelError("Error", "Invalid information");
                    return View(model);
                }
            }
            return View(model);
        }

    }
}