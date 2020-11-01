using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BLL
{
    class ViewInventories
    {
        public static string locIdInput = Console.ReadLine().ToString();
        public int locId = Int32.Parse(locIdInput);

        public void GetInventory(int locId)
        {
            IList<InvProduct> products = new List<InvProduct>()
            {
                //load list of products
            };

            var resultList = products.Where(p => p.LocationId == locId).ToList<InvProduct>();

            foreach (InvProduct results in resultList)
            {
                Console.WriteLine(results.ToString());
            }
        }
    }
}
