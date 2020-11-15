using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using StoreWeb.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using NpgsqlTypes;
using Serilog;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace StoreWeb.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly IConfiguration _configuration;
        private readonly string apiBaseUrl;
        readonly HttpClient client = new HttpClient();

        public CustomerController(ILogger<CustomerController> logger, 
            IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
            apiBaseUrl = _configuration.GetValue<string>("https://localhost:44317/api/");
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PlaceOrder()
        {
            return View();
        }

       /* [HttpPost]
        public IActionResult PlaceOrder(int locationId)
        {
            var user = JsonConvert.DeserializeObject<User>
                (HttpContext.Session.GetString("SessionUser"));
            Cart cart = new Cart
            {
                UserId = user.UserId,
                //LocationId = user.LocationId,
            };
            return RedirectToAction("StartOrdering", "Customer", cart);
        }
*/

/*        public IActionResult StartOrdering(Cart cart)
        {
            cart.Order = new Order();
            return View(cart);
        }*/

        public IActionResult OrderHistory()
        {
            var user = JsonConvert.DeserializeObject<User>
                (HttpContext.Session.GetString("SessionUser"));
            User orderUser = new User { Username = user.Username };
            return View(orderUser);
        }

        public IActionResult ViewInventory()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ViewInventory(int locationId)
        {
/*            using (var client = new HttpClient())
            {*/
                client.BaseAddress = new Uri(apiBaseUrl);
                var response = client.GetAsync($"location/get/{locationId}");
                response.Wait();

                var result = response.Result;
                if (result.IsSuccessStatusCode)
                {
                    var jsonString = result.Content.ReadAsStringAsync();
                    jsonString.Wait();

                    var model = JsonConvert.DeserializeObject<Location>(jsonString.Result);
                    return View("ViewInventoryItems", model);
              //  }
            }
            return View();
        }
    }
}