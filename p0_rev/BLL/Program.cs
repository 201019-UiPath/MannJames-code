using System;
using System.Collections.Generic;
using System.Text;
using Libraries;
using Models;

namespace BLL
{
    class Program
    {
        public static void Main(String[] args)
        {
            //prod1.productName.toString();
            Inventory inv = new Inventory();
            inv.Inventories();
            CustFiltering ordList = new CustFiltering();
            ordList.Orders();
        }
    }
}
