using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public int LocationID { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public double ProductPrice { get; set; }

        public Product(int ProductID, int LocationID, string ProductName, string ProductType, double ProductPrice)
        {
            this.ProductID = ProductID;
            this.LocationID = LocationID;
            this.ProductName = ProductName;
            this.ProductType = ProductType;
            this.ProductPrice = ProductPrice;
        }

        public Product()
        {
            this.ProductID = 0;
            this.LocationID = 0;
            this.ProductName = null;
            this.ProductType = null;
            this.ProductPrice = 0.00;
        }





        /*
                public void ProdToString()
                {
                    String prodN = ProductName;
                    String prodT = ProductType;
                    String prodP = ProductPrice;

                    Console.Out.WriteLine(prodN);
                    Console.Out.WriteLine(prodT);
                    Console.Out.WriteLine(prodP);
                }*/



        //public virtual string ToString();
    }
}

        