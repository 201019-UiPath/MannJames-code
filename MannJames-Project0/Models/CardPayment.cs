using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class CardPayment
    {
        int CardNumber { get; set; }
        int CustomerId { get; set; }
        int CVV { get; set; }
        string ExpirationDate { get; set; }
        string BillingAddress { get; set; }
        string City { get; set; }
        string State { get; set; }
        int ZipCode { get; set; }
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
