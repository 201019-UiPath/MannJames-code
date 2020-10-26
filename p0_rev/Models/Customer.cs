using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String PhoneNumber { get; set; }

        public Customer(int CustomerID, string FirstName, string LastName, String PhoneNumber)
        {
            this.CustomerID = CustomerID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
        }

        public Customer()
        {
            this.CustomerID = 0;
            this.FirstName = null;
            this.LastName = null;
            this.PhoneNumber = null;
        }

        public override string ToString()
        {
            string output = "";
            output += $"{CustomerID} {FirstName} {LastName} {PhoneNumber}";
            return output;
        }
    }
}
