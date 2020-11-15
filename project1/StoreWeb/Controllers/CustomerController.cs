using StoreWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace StoreWeb.Controllers
{
    [Route("user")]
    public class CustomerController : Controller
    {
        const string url = "https://localhost:44317/api/";

        private readonly IActionResult LoginRedirectAction;
        private readonly Task<IActionResult> LoginRedirectActionTask;

        private User CurrentCustomer
        {
            get { return HttpContext.Session.Get<User>("CurrentCustomer"); }
            set { HttpContext.Session.Set("CurrentCustomer", value); }
        }
        private List<Inventory> CurrentCart
        {
            get { return HttpContext.Session.Get<List<Inventory>>("CurrentCart"); }
            set { HttpContext.Session.Set<List<Inventory>>("CurrentCart", value); }
        }
        private Location CurrentLocation 
        { 
            get { return HttpContext.Session.Get<Location>("CurrentLocation"); } 
            set { CurrentCart = null; HttpContext.Session.Set<Location>("CurrentLocation", value); } 
        }
        public CustomerController()
        {
            LoginRedirectAction = RedirectToAction("Login", "Home", "-1");
            LoginRedirectActionTask = Task.Factory.StartNew(() => LoginRedirectAction);
        }
        [Route("")]

        public async Task<IActionResult> Index()
        {
            if (CurrentCustomer == null)
            {
                return await LoginRedirectActionTask;
            }
            return await Task.Factory.StartNew(() => View(CurrentCustomer));
        }
        [Route("orders")]
        public async Task<IActionResult> GetOrderHistory(int? sortBy)
        {
            if (CurrentCustomer == null)
            {
                return await LoginRedirectActionTask;
            }
            string request = $"customer/get/orders/{CurrentCustomer.Username}";
            var receivedOrders = await this.GetDataAsync<List<Order>>(request);

            string locationRequest = $"location/get";
            var receivedLocations = await this.GetDataAsync<List<Location>>(locationRequest);
            foreach (Order order in receivedOrders)
            {
                order.Location = receivedLocations.Single(l => l.LocationId == order.LocationId);
            }
            List<Order> sortedOrders = receivedOrders;
            sortedOrders = sortBy switch
            {
                0 => receivedOrders.OrderBy(o => o.OrderDate).ToList(),
                1 => receivedOrders.OrderBy(o => o.OrderDate).Reverse().ToList(),
                2 => receivedOrders.OrderBy(o => o.TotalCost).ToList(),
                3 => receivedOrders.OrderBy(o => o.TotalCost).Reverse().ToList(),
                _ => receivedOrders
            };
            if (receivedOrders != default) 
                return View(sortedOrders
            ); 
            else return StatusCode(500);
        }

        [Route("orders/details")]
        public async Task<IActionResult> ViewOrderDetails(int orderId)
        {
            if (CurrentCustomer == null) return await LoginRedirectActionTask;
            string olisRequest = $"order/products/get/{orderId}";
            var receivedLineItems = await this.GetDataAsync<List<LineItem>>(olisRequest);
            string productsRequest = $"product/get";
            var receivedProducts = await this.GetDataAsync<List<Product>>(productsRequest);
            if (receivedLineItems == null)
            {
                return StatusCode(500);
            }
            foreach (LineItem li in receivedLineItems)
            {
                li.Product = receivedProducts.Single(p => p.ProductId == li.ProductId);
            }
            return View(receivedLineItems);
        }

        [Route("add")]
        public ViewResult AddCustomer() 
        { return View(); }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddCustomer(User customer)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    User newCustomer = new User(customer.Username, customer.Email, customer.Password);
                    await this.PostDataAsync($"customer/add", newCustomer);

                    LoginModel customerData = new LoginModel(customer.Email, customer.Password);
                    return RedirectToAction("Login", "Home", customerData);
                }
                catch (HttpRequestException e)
                {
                    ModelState.AddModelError(string.Empty, e.Message);
                    return View(customer);
                }
            }
            else return View(customer);
        }

        [Route("order/")]
        public async Task<IActionResult> SelectLocation()
        {
            if (CurrentCustomer == null) return await LoginRedirectActionTask;
            string request = $"location/get";

            var locations = await this.GetDataAsync<List<Location>>(request);

            return View(locations);
        }
    }
}