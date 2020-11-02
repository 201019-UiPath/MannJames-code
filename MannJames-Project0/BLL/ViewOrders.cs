using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace BLL
{
   // Order histories should have the option to be sorted by date
    //(latest to oldest and vice versa) or cost(least expensive to 
    //most expensive)
    class ViewOrders
    {
        public List<string> orders = new List<string>()
        {
            //orders.ToString()
        };

        public void GetLocations()
        {
            foreach (string result in orders)
            {
                Console.WriteLine(result.ToString());
            }
        }
    }
}
