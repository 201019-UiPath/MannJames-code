using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Models;
using Libraries;

namespace Libraries
{
    public class InvDrink
    {
        public List<InventoryDrinkProduct> InventoryDrink = new List<InventoryDrinkProduct>()
        {
            //location 1
            new InventoryDrinkProduct(5, 1, "Regular Coffee", "Coffee", 1.29),
            new InventoryDrinkProduct(6, 1, "Decaf Coffee", "Coffee", 1.29),

            //location 2
            new InventoryDrinkProduct(6, 2, "Regular Coffee", "Coffee", 1.29),
            new InventoryDrinkProduct(7, 2, "Decaf Coffee", "Coffee", 1.29),

            //location 3
            new InventoryDrinkProduct(6, 3, "Regular", "Coffee", 1.29),
            new InventoryDrinkProduct(7, 3, "Decaf", "Coffee", 1.29)
        };
    }
}
