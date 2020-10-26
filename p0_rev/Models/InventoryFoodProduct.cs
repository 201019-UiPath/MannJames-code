using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Models
{
    public class InventoryFoodProduct
    {
        public int ProductID { get; set; }
        public int LocationID { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public double ProductPrice { get; set; }
        //public int OrderID { get; set; }
        public int Quantity { get; set; }

        public InventoryFoodProduct(int ProductID, int LocationID, string ProductName, string ProductType,
            double ProductPrice, int Quantity)
        {
            this.ProductID = ProductID;
            this.LocationID = LocationID;
            this.ProductName = ProductName;
            this.ProductType = ProductType;
            this.ProductPrice = ProductPrice;
            this.Quantity = Quantity;
        }

        public override string ToString()
        {
            string output = "";
            output += $"{ProductID} {LocationID} {ProductName} {ProductType} {ProductPrice} {Quantity}";
            return output;
        }
    }
}

        