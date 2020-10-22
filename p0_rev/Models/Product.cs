using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Product
    {
        int productID { get; set; }
        string productName { get; set; }
        string productType { get; set; }
        string productPrice { get; set; }


        public Product(int productID, string productName, string productType, string productPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.productType = productType;
            this.productPrice = productPrice;
        }

        public Product()
        {
            this.productID = 0;
            this.productName = null;
            this.productType = null;
            this.productPrice = null;
        }
/*
        public void ProdToString()
        {
            String prodN = productName;
            String prodT = productType;
            String prodP = productPrice;

            Console.Out.WriteLine(prodN);
            Console.Out.WriteLine(prodT);
            Console.Out.WriteLine(prodP);
        }*/
        
        public void PTS(Product product)
        {
            Console.Out.WriteLine($"{Product.productName}");
        }


        //public virtual string ToString();
    }
}

        