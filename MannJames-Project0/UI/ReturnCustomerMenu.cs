using System;
using StoreDB;
using BLL;
using Models;
using Microsoft.AspNetCore.Server.IIS.Core;

namespace UI
{
    public class ReturnCustomerMenu : IMenu
    {
        private string userInput;
        private IMessagingService service;
        private CustomerService CustomerService;
        private ICustomersRepo custRepo;
        private NewOrder newOrder;
        private DBRepo dBRepo;
        private CustomerService customerService;
        private int customerId;
        private IOrderRepo orderRepo;
        private OrderService orderService;

        public ReturnCustomerMenu
            (ICustomersRepo custRepo, IMessagingService service)
        {
            this.custRepo = custRepo;
            this.service = service;
            this.orderRepo = orderRepo;
            this.orderService = orderService;
        }

        public void Start() {
            Console.WriteLine("What is your customer number?");
            int customerId = Int32.Parse(Console.ReadLine());
            string name = customerService.GetCustomerById(customerId)
                .FirstName;
            do
            {
                Console.WriteLine($" Welcome {name}!");
                
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[0] Make order");
                Console.WriteLine("[1] View past orders");
                Console.WriteLine("[2] Exit");

                userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case "0":
                        newOrder.Start();
                        break;
                    case "1":
                        orderService.GetOrdersByCustomer(customerId);
                        break;
                    case "2":
                        Console.WriteLine("Thank you for visiting! Until next time!");
                        break;
                    default:
                        service.InvalidInputMessage();
                        break;
                }
            }
            while (!(userInput.Equals("3"))) ;
        }
    }
}
