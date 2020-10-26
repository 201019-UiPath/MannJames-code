using System;
using System.Collections.Generic;
using System.Text;
using Libraries;
using Models;

namespace Libraries
{
    public class OrdDrink
    {
        public List<OrderDrinkProduct> OrderDrink = new List<OrderDrinkProduct>()
        {
            new OrderDrinkProduct(6, "Regular", "Cofee", 1.29, 1, 2),
            new OrderDrinkProduct(6, "Regular", "Cofee", 1.29, 2, 4),
            new OrderDrinkProduct(7, "Decaf", "Cofee", 1.29, 2, 1),
            new OrderDrinkProduct(6, "Regular", "Cofee", 1.29, 4, 1)
        };
    }
}
