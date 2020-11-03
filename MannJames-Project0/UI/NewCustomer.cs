using System;
using System.Collections.Generic;
using System.Text;
using Models;
using StoreDB;

namespace UI
{
    public class NewCustomer : IMenu
    {

        public void Start()
        {
            Customer customer = new Customer();
            Console.WriteLine("Welcome! Please fill in the following info to get started!");
            Console.WriteLine("What is your first name?");
            Console.WriteLine("What is your last name?");
            Console.WriteLine("What is your phone number without dashes or parenthesis? " +
                "(ex. 1234567890)");
            customer.FirstName = Console.ReadLine();
            customer.LastName = Console.ReadLine();
            customer.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            //add customer
        }
    }
}
