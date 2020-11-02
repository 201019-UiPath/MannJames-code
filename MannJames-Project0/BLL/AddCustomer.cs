using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Models;

namespace BLL
{
    public class AddCustomer
    {
        public static string CustomerIdS = Console.ReadLine().ToString();
        public static string FirstName = Console.ReadLine().ToString();
        public static string LastName = Console.ReadLine().ToString();
        public static string PhoneNumberS = Console.ReadLine().ToString();

        public static int CustomerId = Int32.Parse(CustomerIdS);
        public static int PhoneNumber = Int32.Parse(PhoneNumberS);

        public void NewCustomer()
        {
            _ = new Customer(CustomerId, FirstName,
                LastName, PhoneNumber);

            //add customer to DAL
        }
    }
}
