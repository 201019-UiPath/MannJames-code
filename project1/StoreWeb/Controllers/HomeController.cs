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

namespace StoreWeb.Controllers
{
    public class HomeController : Controller
    {
        private const string url = "https://localhost:44317/";
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public ViewResult Login()
        {
            var model = new LoginModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(url);
                    var response = client.GetAsync($"user/get?name={model.Username}");
                    //HttpRequestException: 
                    //No connection could be made because the target machine actively refused it.

                    //SocketException: 
                    //No connection could be made because the target machine actively refused it.

                    response.Wait();

                    var result = response.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        var jsonString = result.Content.ReadAsStringAsync();
                        jsonString.Wait();

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
                }
            }
            return View(model);
        }
        [HttpPost]
        public IActionResult SignUp(SignUpModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Password == model.ConfirmPassword)
                {
                    User newUser = new User();
                    newUser.Username = model.Username;
                    newUser.Email = model.Email;
                    newUser.LocationId = model.LocationId;
                    newUser.Type = Models.User.UserType.Customer;
                    newUser.Password = model.Password;

                    using (var client = new HttpClient())
                    {
                        client.BaseAddress = new Uri(url);

                        var json = JsonConvert.SerializeObject(newUser);
                        var data = new StringContent(json, Encoding.UTF8, "application/json");

                        var response = client.PostAsync("user/add", data);
                        response.Wait();

                        var result = response.Result;
                        if (result.IsSuccessStatusCode)
                        {
                            HttpContext.Session.SetObject("User", newUser);
                            return RedirectToAction("GetInventory", "Customer");
                        }
                    }
                }
                else
                {
                    // TODO Failed sign in
                }
            }
            return View(model);
        }
        [HttpGet]
        public ViewResult SignUp()
        {
            var model = new SignUpModel();

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
                        locationOptions.Add(new SelectListItem 
                        { Selected = false, Text = $"{loc.City}, {loc.State}", Value = loc.LocationId.ToString() });
                    }
                    model.LocationOptions = locationOptions;
                }
            }

            return View(model);
        }
        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();

            return View("Login");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}