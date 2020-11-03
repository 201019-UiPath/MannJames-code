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
        private CustomerService task;
        private ICustomersRepo custRepo;

        public ReturnCustomerMenu
            (ICustomersRepo custRepo, IMessagingService service, CustomerService task)
        {
            this.custRepo = custRepo;
            this.task = task;
            this.service = service;
        }

        public void Start() {
            Console.WriteLine("What is your customer number?");
            int customerId = Convert.ToInt32(Console.ReadLine());
            task.GetCustomerById(customerId);
            Customer customer = task.GetCustomerById(customerId);
            do
            {
                Console.WriteLine($" Welcome {customer.FirstName}!");
                
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[0] Make Order");
                Console.WriteLine("[1] View Past Orders");
                Console.WriteLine("[2] Exit");

                userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case "0":
                        //make order
                        break;
                    case "1":
                        //view orders
                        break;
                    case "2":
                        Console.WriteLine("Thank you for visiting! Until next time!");
                        break;
                    default:
                        break;
                }
            }
            while (!(userInput.Equals("3"))) ;
        }
    }
}
