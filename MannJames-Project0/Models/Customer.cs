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
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        //orders
        public virtual ICollection<Order> Orders { get; set; }
        //card payments

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
