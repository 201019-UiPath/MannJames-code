using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Models;
using Libraries;

namespace Libraries
{
    public class ProductLib
    {

        public List<Product> ProductList = new List<Product>()
        {
            //location 1
            new Product(1, 1, "Original", "Donuts", 1.99),
            new Product(2, 1, "Glazed", "Donuts", 1.99),
            new Product(3, 1, "Chocolate Frosted", "Donuts", 1.99),
            new Product(4, 1, "Vanilla Frosted", "Donuts", 1.99),

            //location 2
            new Product(1, 2, "Original", "Donuts", 1.99),
            new Product(2, 2, "Glazed", "Donuts", 1.99),
            new Product(3, 2, "Chocolate Frosted", "Donuts", 1.99),
            new Product(4, 2, "Vanilla Frosted", "Donuts", 1.99),
            new Product(5, 2, "Manager's Special", "Donuts", 1.99),
            new Product(6, 2, "Regular Coffee", "Cofee", 1.29),
            new Product(7, 2, "Decaf Coffee", "Cofee", 1.29),

            //location 3
            new Product(1, 3, "Original", "Donuts", 1.99),
            new Product(2, 3, "Glazed", "Donuts", 1.99),
            new Product(3, 3, "Chocolate Frosted", "Donuts", 1.99),
            new Product(4, 3, "Vanilla Frosted", "Donuts", 1.99),
            new Product(5, 3, "Manager's Special", "Donuts", 1.99),
            new Product(6, 3, "Regular Coffee", "Cofee", 1.29),
            new Product(7, 3, "Decaf Coffee", "Cofee", 1.29)
        };
    /*

        //location 1
        public Product prod1_1 = new Product(1, 1, "Original", "Donuts", 1.99);
        public Product prod2_1 = new Product(2, 1, "Glazed", "Donuts", 1.99);
        public Product prod3_1 = new Product(3, 1, "Chocolate Frosted", "Donuts", 1.99);
        public Product prod4_1 = new Product(4, 1, "Vanilla Frosted", "Donuts", 1.99);

        //location 2
        public Product prod1_2 = new Product(1, 2, "Original", "Donuts", 1.99);
        public Product prod2_2 = new Product(2, 2, "Glazed", "Donuts", 1.99);
        public Product prod3_2 = new Product(3, 2, "Chocolate Frosted", "Donuts", 1.99);
        public Product prod4_2 = new Product(4, 2, "Vanilla Frosted", "Donuts", 1.99);
        public Product prod5_2 = new Product(5, 2, "Manager's Special", "Donuts", 1.99);
        public Product prod6_2 = new Product(6, 2, "Regular Coffee", "Cofee", 1.29);
        public Product prod7_2 = new Product(7, 2, "Decaf Coffee", "Cofee", 1.29);

        //location 3
        public Product prod1_3 = new Product(1, 3, "Original", "Donuts", 1.99);
        public Product prod2_3 = new Product(2, 3, "Glazed", "Donuts", 1.99);
        public Product prod3_3 = new Product(3, 3, "Chocolate Frosted", "Donuts", 1.99);
        public Product prod4_3 = new Product(4, 3, "Vanilla Frosted", "Donuts", 1.99);
        public Product prod5_3 = new Product(5, 3, "Manager's Special", "Donuts", 1.99);
        public Product prod6_3 = new Product(6, 3, "Regular Coffee", "Cofee", 1.29);
        public Product prod7_3 = new Product(7, 3, "Decaf Coffee", "Cofee", 1.29);
    */
    }
}
