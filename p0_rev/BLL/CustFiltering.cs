using System;
using System.Collections.Generic;
using System.Text;
using Libraries;
using System.Collections.Concurrent;
using System.Dynamic;
using System.Linq;
using Models;
using System.ComponentModel;

namespace BLL
{
    class CustFiltering
    {
        public CustFiltering(List<Customer> customerList)
        {
            CustomerLib cuLib = new CustomerLib();
            cuLib.CustomerList.Where(Customers => Customers.CustomerID == 3)
                .ToList()
                .ForEach(Customer => Console.WriteLine
                (
                    $"Welcome {Customer.FirstName} {Customer.LastName} at {Customer.PhoneNumber}"
                ));
           



           //Console.WriteLine("Your order history:");


        }

    }
}
