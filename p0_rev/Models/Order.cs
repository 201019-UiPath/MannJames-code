using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int LocationID { get; set; }
        public int CustomerID { get; set; }
        public string OrderDate { get; set; }
        public string PickUpDate { get; set; }
        public Boolean PickUp { get; set; }
        public double TotalCost { get; set; }

        public Order(int OrderID, int LocationID, 
            int CustomerID, string OrderDate)
        {
            this.OrderID = OrderID;
            this.LocationID = LocationID;
            this.CustomerID = CustomerID;
            this.OrderDate = OrderDate;
        }

        public Order()
        {
            this.OrderID = 0;
            this.LocationID = 0;
            this.CustomerID = 0;
            this.OrderDate = "00/00/0000";
        }
        public override string ToString()
        {
            string output = "";
            output += $"{OrderID} {LocationID} {CustomerID} {OrderDate}";
            return output;
        }
    }
}
