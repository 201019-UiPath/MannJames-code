using System;
using System.Collections.Generic;
using System.Text;

namespace BLL
{
    class OrderList
    {
        
        CustomerLib cL = new CustomerLib();
        cL.CustomerList.Where(Customers => Customers.CustomerID == 1)
                .ToList()
                .ForEach(Customer => Console.WriteLine
                (
                    $"Welcome {Customer.FirstName} {Customer.LastName} at {Customer.PhoneNumber}"
                ));
    }
}
