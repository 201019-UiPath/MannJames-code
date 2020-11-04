using BLL;
using StoreDB;
using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Microsoft.AspNetCore.Mvc.TagHelpers.Cache;

namespace UI
{
    public class NewOrder : IMenu
    {
        Order order = new Order();
        Customer customer = new Customer();
        private string userInput;
        private IMessagingService service;
        private CustomerService custTask;
        private IOrderRepo orderRepo;
        private ReturnCustomerMenu returnCustomerMenu;
        private ILocationRepo locationRepo;
        private LocationService locationTask;
        private InventoryService inventoryService;
        private bool keepGoing = true;
        public OrderService orderTask;
        private MainMenu mainMenu;

        public NewOrder
            (IOrderRepo orderRepo, IMessagingService service, 
            CustomerService custTask, ILocationRepo locationRepo,
            LocationService locationTask)
        {
            this.orderRepo = orderRepo;
            this.custTask = custTask;
            this.service = service;
            this.locationRepo = locationRepo;
            this.locationTask = locationTask;
        }
        public void Start()
        {
            do
            {
                Console.WriteLine("Confirm your customer number");
                int customerId = Convert.ToInt32(Console.ReadLine());
                Customer customer = custTask.GetCustomerById(customerId);
                //location list
                Console.WriteLine("Please input Location ID Number");
                int locationId = Convert.ToInt32(Console.ReadLine());
               // Location location = locationTask.GetLocationById(locationId);
                inventoryService.GetInvByLocation(locationId);

                OrdProduct ordProduct = new OrdProduct();


                while (keepGoing)
                {
                    Console.WriteLine("Pick number matching product");
                    int iProductId = Convert.ToInt32(Console.ReadLine());
                    string name = inventoryService.GetInvProductById(iProductId);
                    ordProduct.OProductName = name; 
                    Console.WriteLine("How many?");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    ordProduct.Quantity = quantity;
                    orderTask.AddProduct(ordProduct);
                    Console.WriteLine("Add another product");
                    Console.WriteLine("Press N to stop adding");
                    Console.WriteLine("Press any other button to stop adding");
                    var continueAdding = Console.ReadLine();
                    keepGoing = continueAdding.ToUpper() != "N";
                }

                orderTask.AddOrder(order);

                Console.WriteLine("All done. Submit order?");
                Console.WriteLine("[0] Yes");
                Console.WriteLine("[1] No and exit");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        Console.WriteLine("Order submitted");
                        mainMenu.Start();
                        break;
                    case "1":
                        Console.WriteLine("Bye for now!");
                        break;
                    default:
                        service.InvalidInputMessage();
                        break;
                }
            }

            while (!(userInput.Equals("1")));

        }


    }
}
