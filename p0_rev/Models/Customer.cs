using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Customer
    {
        int CustomerId;
        string FirstName;
        string LastName;
        int PhoneNumber;

        public Customer(int CustomerId, string FirstName, string LastName, int PhoneNumber)
        {
            this.CustomerId = CustomerId;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
        }

        public override string ToString()
        {
            return $"{ CustomerId } { FirstName } { LastName } { PhoneNumber }";
        }
    }
}
