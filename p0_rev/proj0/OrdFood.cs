using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Libraries
{
    class OrdFood
    {
        //list of OrderFoodProducts associated with order
        public List<OrderFoodProduct> OrderFood = new List<OrderFoodProduct>()
        {
            //Product(int ProductID, string ProductName, string ProductType,
            //double ProductPrice, int OrderID, int Quantity)

            //order 1 
            new OrderFoodProduct(1, "Original", "Donuts", 1.99, 1, 6),
            new OrderFoodProduct(2, "Glazed", "Donuts", 1.99, 1, 12),

            //order 2
            new OrderFoodProduct(1, "Original", "Donuts", 1.99, 2, 12),
            new OrderFoodProduct(3, "Chocolate Frosted", "Donuts", 1.99, 2, 12),
            new OrderFoodProduct(4, "Vanilla Frosted", "Donuts", 1.99, 2, 6),
            new OrderFoodProduct(5, "Manager's Special", "Donuts", 1.99,2 , 6),



            //order 3
            new OrderFoodProduct(1, "Original", "Donuts", 1.99, 3, 6),

            //order 4
            new OrderFoodProduct(1, "Original", "Donuts", 1.99,4, 3),
            new OrderFoodProduct(2, "Glazed", "Donuts", 1.99, 4, 6),


        };
    }
}
