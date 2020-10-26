using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Models;
using Libraries;

namespace Libraries
{
    public class InvFood
    {
        public List<InventoryFoodProduct> InventoryFood = new List<InventoryFoodProduct>()
        {
            //location 1
            new InventoryFoodProduct(1, 1, "Original", "Donuts", 1.99, 20),
            new InventoryFoodProduct(2, 1, "Glazed", "Donuts", 1.99, 21),
            new InventoryFoodProduct(3, 1, "Chocolate Frosted", "Donuts", 1.99, 22),
            new InventoryFoodProduct(4, 1, "Vanilla Frosted", "Donuts", 1.99, 12),

            //location 2
            new InventoryFoodProduct(1, 2, "Original", "Donuts", 1.99, 9),
            new InventoryFoodProduct(2, 2, "Glazed", "Donuts", 1.99, 15),
            new InventoryFoodProduct(3, 2, "Chocolate Frosted", "Donuts", 1.99, 8),
            new InventoryFoodProduct(4, 2, "Vanilla Frosted", "Donuts", 1.99, 14),
            new InventoryFoodProduct(5, 2, "Manager's Special", "Donuts", 1.99, 2),

            //location 3
            new InventoryFoodProduct(1, 3, "Original", "Donuts", 1.99, 10),
            new InventoryFoodProduct(2, 3, "Glazed", "Donuts", 1.99, 12),
            new InventoryFoodProduct(3, 3, "Chocolate Frosted", "Donuts", 1.99, 11),
            new InventoryFoodProduct(4, 3, "Vanilla Frosted", "Donuts", 1.99, 8),
            new InventoryFoodProduct(5, 3, "Manager's Special", "Donuts", 1.99, 5)
        };
    }
}
