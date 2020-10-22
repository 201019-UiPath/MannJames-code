using System;
using System.Collections.Generic;
using System.Text;

namespace project0
{
    class Order
    {
        int orderID { get; set; }
        int locationID { get; set; }
        int customerID { get; set; }
        string orderDate { get; set; }
        string pickUpDate { get; set; }
        Boolean pickUp { get; set; }
        //if 1 means pickup happened
        //presence of pickup date means 1
        //1 requires pickup datetime

        List<String> orderList = new List<String>();
        double totalCost { get; set; }

        public Order(int orderID, int locationID, 
            int customerID, string orderDate)
        {
            this.orderID = orderID;
            this.locationID = locationID;
            this.customerID = customerID;
            this.orderDate = orderDate;
            Console.WriteLine($"{orderDate}");
            //need to create list for orders
        }
    }
}
