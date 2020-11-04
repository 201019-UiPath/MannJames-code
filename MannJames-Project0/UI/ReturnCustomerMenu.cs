using System;
using StoreDB;
using BLL;
using Models;

namespace UI
{
    public class ReturnCustomerMenu : IMenu
    {
        private string userInput;
        private IMessagingService service;
        private CustomerService CustomerService;
        private ICustomersRepo custRepo;
        private NewOrder newOrder;
        private ViewOrders viewOrders;
        private DBRepo dBRepo;
        private CustomerService customerService;
        private int customerId;

        public ReturnCustomerMenu
            (DBRepo dBRepo, IMessagingService service)
        {
            this.dBRepo = dBRepo;
            this.service = service;
        }

        public void Start() {
            Console.WriteLine("What is your customer number?");
            int customerId = Int32.Parse(Console.ReadLine());
            //Customer customer = 
            string name = CustomerService.GetCustomerById(customerId)
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
                        viewOrders.Start();
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
