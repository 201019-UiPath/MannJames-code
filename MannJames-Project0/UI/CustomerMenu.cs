using BLL;
using StoreDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    public class CustomerMenu: IMenu
    {
        private string userInput;
        private DBRepo repo;
        private IMessagingService service;
        private CustomerMenu customerMenu;
        private NewCustomer newCustomer;
        private ReturnCustomerMenu returnCustomerMenu;
        private StoreDBContext context;
        private CustomerService customerService;

        public CustomerMenu(DBRepo repo)
        {
            this.repo = repo;
            this.service = service;
            this.newCustomer = new NewCustomer
                (new DBRepo(context), new MessagingService());
            this.returnCustomerMenu = new ReturnCustomerMenu
                (new DBRepo(context), new MessagingService());
        }

        public void Start()
        {
            do
            {
                Console.WriteLine("Welcome! Are you a returning customer?");
                Console.WriteLine("[0] No. Please sign me up!");
                Console.WriteLine("[1] Yes. Take me home country roads!");
                Console.WriteLine("[2] Exit");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        newCustomer.Start();
                        break;
                    case "1":
                        returnCustomerMenu.Start();
                        break;
                    case "2":
                        Console.WriteLine("Thank you for visiting! Until next time!");
                        break;
                    default:
                        service.InvalidInputMessage();
                        break;
                }
            }

            while (!(userInput.Equals("2")));
        }
    }
}
