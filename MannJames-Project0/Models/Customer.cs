using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Customer
    {
        [Key]
        [Required]
        public int CustomerId;
        [Required]
        public string FirstName;
        [Required]
        public string LastName;
        [Required]
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

        public Customer()
        {
            this.CustomerId = 0;
            this.FirstName = null;
            this.LastName = null;
            this.PhoneNumber = 0000000000;
        }

        public override string ToString()
        {
            return $"{ CustomerId } { FirstName } { LastName } { PhoneNumber }";
        }
    }
}
