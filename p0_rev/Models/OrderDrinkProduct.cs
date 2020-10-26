using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class OrderDrinkProduct
    {
        public int ProductID { get; set; }
        //public int LocationID { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public double ProductPrice { get; set; }
        public int OrderID { get; set; }
        public int Quantity { get; set; }

        public OrderDrinkProduct(int ProductID, string ProductName, string ProductType,
            double ProductPrice, int OrderID, int Quantity)
        {
            this.ProductID = ProductID;
            //this.LocationID = LocationID;
            this.ProductName = ProductName;
            this.ProductType = ProductType;
            this.ProductPrice = ProductPrice;
            this.OrderID = OrderID;
            this.Quantity = Quantity;
        }
        public override string ToString()
        {
            string output = "";
            output += $"{ProductID} {ProductName} {ProductType} {ProductPrice} {OrderID} {Quantity}";
            return output;
        }
    }
}
