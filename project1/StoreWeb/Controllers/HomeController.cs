﻿using System;
using System.Diagnostics;
using System.Net.Http;
using StoreWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace StoreWeb.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly string apiBaseUrl;
        private User loggedInUser;

        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;

            apiBaseUrl = _configuration.GetValue<string>("https://localhost:44317/api/");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (user != null)
            {
                HttpContext.Session.SetString("SessionUser", JsonConvert.SerializeObject(user));
                return RedirectToAction("Index", "Manager", user);
            }
            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult SignUp()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult CustomerLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CustomerLogin(User user)
        {
            if (user != null)
            {
                HttpContext.Session.SetString("SessionUser", JsonConvert
                    .SerializeObject(user));
                return RedirectToAction("Index", "Customer", user);
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult SignUp(User user)
        {
            if (user == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("CustomerLogin", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}