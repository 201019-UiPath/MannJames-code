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
        [Column(Order = 1)]
        public int CardNumber { get; set; }

        [Key]
        [Column(Order=2)]
        public int CustomerId { get; set; }
        public int CVV { get; set; }
        public string ExpirationDate { get; set; }
        public string BillingAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
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
    }
}
