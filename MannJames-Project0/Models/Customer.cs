using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Customer
    {
        public int CustomerId;
        public string FirstName;
        public string LastName;
        public int PhoneNumber;
        //orders
        public virtual ICollection<Order> Orders { get; set; }
        //card payments
        public virtual ICollection<CardPayment> Cards { get; set; }

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
