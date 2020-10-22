using System;
using System.Collections.Generic;
using System.Text;

namespace project0
{
    public class Product
    {
        int productID { get; set; }
        //list locations;
        string productName { get; set; }
        string productType { get; set; }
        //convert name to lowercase
        string productPrice { get; set; }

 
        public Product(int productID, string productName, string productType, string productPrice)
        {
            this.productID = productID;
            this.productName = productName;
            this.productType = productType;
            this.productPrice = productPrice;

            Console.WriteLine($"{productName} {productType} " +
                $"{productPrice}");
        }
        
       /* public static void Products()
        {
            Product prod1 = new Product
            (
                1,
                "Truffle Olive Oil",
                "Oils",
                "32.50"
            );
            Product prod2 = new Product
            (
                1,
                "Truffle Olive Oil",
                "Oils",
                "32.50"
            );
            Product prod3 = new Product
            (
                2,
                "EV Olive Oil",
                "Oils",
                "9.50"
            );
            Console.WriteLine("Our inventory consists of...");
            Console.WriteLine($"{prod1.productName} {prod1.productType} " +
                $"{prod1.productPrice}");
            Console.WriteLine($"{prod2.productName} {prod2.productType} " +
                $"{prod2.productPrice}");
            Console.WriteLine($"{prod3.productName} {prod3.productType} " +
                $"{prod3.productPrice}");
        }*/
    }
}

        