using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using Models;

namespace Libraries
{
    public class ProductLib
    {
        public Product prod1 = new Product(1, "EV Olive Oil", "Oils", 9.50);
        public Product prod2 = new Product(2, "Truffle Olive Oil", "Oils", 32.50);
    }
}
