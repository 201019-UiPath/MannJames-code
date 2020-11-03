using System;
using System.Collections.Generic;
using System.Text;
using Models;
using StoreDB;

namespace UI
{
    public class NewCustomer : IMenu, IConfirmation
    {

        Customer customer = new Customer();
        private string userInput;

/*        public MainMenu(StoreDBContext context)
        {
            this.customerMenu = new CustomerMenu(new DBRepo(context), new MessagingService());
            this.employeeMenu = new EmployeeMenu(new DBRepo(context), new MessagingService());
            this.locationMenu = new LocationMenu(new DBRepo(context), new MessagingService());

        }*/

        public void Start()
        {
            Console.WriteLine("Welcome! Please fill in the following info to get started!");
            Console.WriteLine("What is your first name?");
            customer.FirstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            customer.LastName = Console.ReadLine();
            Console.WriteLine("What is your phone number without dashes or parenthesis? " +
                "(ex. 1234567890)");
            customer.PhoneNumber = Convert.ToInt32(Console.ReadLine());
        }

        public void Confirm()
        {
            do
            {
                Console.WriteLine(customer.ToString());
                Console.WriteLine("Is this the right info?");
                Console.WriteLine("[0] Yes");
                Console.WriteLine("[1] No");

                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        //addCustomer
                        break;
                    case "1":
                        //goBack
                        break;
                    default:
                        break;
                }
            }
            while (!(userInput.Equals("1")));
        }
    }
}
