using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Libraries
{
    public class OrderLib
    {
        public Order ord1 = new Order(1,1,3,"3/18/2020");
        public Order ord2 = new Order(2,1,2,"4/2/2020");
        public Order ord3 = new Order(3,2,3,"4/17/2020");
        public Order ord4 = new Order(4,1,1,"8/25/2020");

        //list of products associated with order
        public List<Product> OrderProducts = new List<Product>()
        {
            //order 1
            new Product(1, 1, "Original", "Donuts", 1.99),
            new Product(2, 1, "Glazed", "Donuts", 1.99),
            new Product(3, 1, "Chocolate Frosted", "Donuts", 1.99),
            new Product(4, 1, "Vanilla Frosted", "Donuts", 1.99),

            //order 2
            new Product(1, 2, "Original", "Donuts", 1.99),
            new Product(2, 2, "Glazed", "Donuts", 1.99),
            new Product(3, 2, "Chocolate Frosted", "Donuts", 1.99),
            new Product(4, 2, "Vanilla Frosted", "Donuts", 1.99),
            new Product(5, 2, "Manager's Special", "Donuts", 1.99),
            new Product(6, 2, "Regular Coffee", "Cofee", 1.29),
            new Product(7, 2, "Decaf Coffee", "Cofee", 1.29),

            //order 3
            new Product(1, 3, "Original", "Donuts", 1.99),
            new Product(2, 3, "Glazed", "Donuts", 1.99),
            new Product(3, 3, "Chocolate Frosted", "Donuts", 1.99),
            new Product(4, 3, "Vanilla Frosted", "Donuts", 1.99),
            new Product(5, 3, "Manager's Special", "Donuts", 1.99),
            new Product(6, 3, "Regular Coffee", "Cofee", 1.29),
            new Product(7, 3, "Decaf Coffee", "Cofee", 1.29)

            //order 4
        };

    }
}