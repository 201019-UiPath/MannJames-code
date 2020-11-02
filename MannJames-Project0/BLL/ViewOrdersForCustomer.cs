using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    class ViewOrdersForCustomer
    {
        public void ViewOrders(int custId)
        {
            IList<Order> products = new List<Order>()
            {
                //load list of products for order
            };

            var resultList = products.Where(p => p.CustomerId == custId).ToList<Order>();

            foreach (Order results in resultList)
            {
                Console.WriteLine(results.ToString());
            }
        }
    }
}
