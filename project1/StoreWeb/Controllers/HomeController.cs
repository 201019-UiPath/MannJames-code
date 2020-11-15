using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using StoreWeb.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StoreWeb.Controllers
{

    public class HomeController : Controller
    {
        const string url = "https://localhost:44317/api/";
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ViewResult Login(int? sessionExists)
        {
            if (sessionExists == 0)
            {
                ViewData["Redirect"] = "Your session does not exist. Please sign in.";
            }
            return View();
        }
        public async Task<IActionResult> Login(LoginModel userInput)
        {
            if (ModelState.IsValid)
            {
                string inputUsername = userInput.Username;
                string inputPassword = userInput.Password;
                try
                {
                    string request = $"user/get/name={inputUsername}";
                    var inputCustomer = await this.GetDataAsync<User>(request);
                    if (inputCustomer.Password == inputPassword && inputCustomer.Username == inputUsername)
                    {
                        HttpContext.Session.Set<User>("CurrentCustomer", inputCustomer);
                        return RedirectToAction("Index", "Customer");
                    }
                    else
                    {
                        return View(userInput);
                    };
                }
                catch (HttpRequestException)
                {
                    return View(userInput);
                }
                catch (NullReferenceException)
                {
                    return View(userInput);
                }
            }
            return View(userInput);
        }
        [Route(("Privacy/"))]
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        [Route(("Controller=Home"))]
        public IActionResult About()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}