using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Libraries
{
    public class CustomerLib
    {
        public List<Customer> CustomerList = new List<Customer>() 
        {
            new Customer(1,"Jonathan","Archer","9544443370"),
            new Customer(2,"Steven","Tyler","7548675309"),
            new Customer(3,"Jotaro","Kujo","9547777777")
        };
    }
}
