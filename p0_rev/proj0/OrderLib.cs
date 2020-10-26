using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace Libraries
{
    public class OrderLib
    {
        public List<Order> orderList = new List<Order>()
        {
            new Order(1, 1, 3, "3/18/2020"),
            new Order(2, 1, 2, "4/2/2020"),
            new Order(3, 2, 3, "4/17/2020"),
            new Order(4, 1, 1, "8/25/2020")
        };

        //list of products associated with order
        public List<Product> OrderProducts = new List<Product>()
        {
            //Product(int ProductID, string ProductName, string ProductType,
            //double ProductPrice, int OrderID, int Quantity)

            //order 1 
            new Product(1, "Original", "Donuts", 1.99, 1, 6),
            new Product(2, "Glazed", "Donuts", 1.99, 1, 12),
            new Product(6, "Regular", "Cofee", 1.29, 1, 2),

            //order 2
            new Product(1, "Original", "Donuts", 1.99, 2, 12),
            new Product(3, "Chocolate Frosted", "Donuts", 1.99, 2, 12),
            new Product(4, "Vanilla Frosted", "Donuts", 1.99, 2, 6),
            new Product(5, "Manager's Special", "Donuts", 1.99,2 , 6),
            new Product(6, "Regular", "Cofee", 1.29, 2, 4),
            new Product(7, "Decaf", "Cofee", 1.29, 2, 1),

            //order 3
            new Product(1, "Original", "Donuts", 1.99, 3, 6),

            //order 4
            new Product(1, "Original", "Donuts", 1.99,4, 3),
            new Product(2, "Glazed", "Donuts", 1.99, 4, 6),
            new Product(6, "Regular", "Cofee", 1.29, 4, 1)
        };
    }
}