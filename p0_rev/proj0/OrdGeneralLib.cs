using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace Libraries
{
    public class OrdGeneralLib
    {
        public List<Order> orderList = new List<Order>()
        {
            new Order(1, 1, 3, "3/18/2020"),
            new Order(2, 1, 2, "4/2/2020"),
            new Order(3, 2, 3, "4/17/2020"),
            new Order(4, 1, 1, "8/25/2020")
        };
    }
}