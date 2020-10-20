using System;
using System.Collections.Generic;

namespace project_0
{
    class Order
    {
        int orderID{get;set;}
        int locationID{get;set;}
        int customerID{get;set;}
        string orderDate{get;set;}
        string pickUpDate{get;set;}
        Boolean pickUp{get;set;}
        //if 1 means pickup happened
        //presence of pickup date means 1
        //1 requires pickup datetime

        List<String> orderList = new List<String>();

        float totalCost{get;set;}


    }
}
