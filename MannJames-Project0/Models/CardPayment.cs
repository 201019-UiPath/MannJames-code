using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class CardPayment
    {
        [Key]
        [Required]
        public int CardNumber { get; set; }

        [ForeignKey("CustId_FK")]
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int CVV { get; set; }
        [Required]
        public string ExpirationDate { get; set; }
        [Required]
        public string BillingAddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public int ZipCode { get; set; }
        public virtual Customer Customer { get; set; }

        public CardPayment(int CardNumber, int CustomerId, int CVV, string ExpirationDate, 
            string BillingAddress, string City, string State, int ZipCode)
        {
            this.CardNumber = CardNumber;
            this.CustomerId = CustomerId;
            this.CVV = CVV;
            this.ExpirationDate = ExpirationDate;
            this.BillingAddress = BillingAddress;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
        }
        public CardPayment()
        {
            this.CardNumber = 0;
            this.CustomerId = 0;
            this.CVV = 0;
            this.ExpirationDate = null;
            this.BillingAddress = null;
            this.City = null;
            this.State = null;
            this.ZipCode = 00000;
        }
    }
}
