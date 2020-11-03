﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using BLL;
using Models;
using StoreDB;

namespace UI
{
    public class NewCustomer : IMenu
    {

        Customer customer = new Customer();
        private string userInput;
        private IMessagingService service;
        private StoreService task;
        private ICustomersRepo custRepo;

        public NewCustomer
            (ICustomersRepo custRepo, IMessagingService service, StoreService task)
        {
            this.custRepo = custRepo;
            this.task = task;
            this.service = service;
        }

        public void Start()
        {
            do
            {
                Console.WriteLine("Welcome! Please fill in the following info to get started!");
                Console.WriteLine("What is your first name?");
                customer.FirstName = Console.ReadLine();
                Console.WriteLine("What is your last name?");
                customer.LastName = Console.ReadLine();
                Console.WriteLine("What is your phone number without dashes or parenthesis? " +
                    "(ex. 1234567890)");
                customer.PhoneNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(customer.ToString());
                Console.WriteLine("Is this the right info?");
                Console.WriteLine("[0] Yes");
                Console.WriteLine("[1] No");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        task.AddCustomer(customer);
                        break;
                    case "1":
                        //goBack
                        break;
                    default:
                        break;
                }
            } while (!(userInput.Equals("1")));
        }
    }
}
