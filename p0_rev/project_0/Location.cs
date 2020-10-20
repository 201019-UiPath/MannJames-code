using System;
using System.Collections.Generic;

namespace project_0
{
    class Location
    {
        string locationID{get;set;}
        //list of available products
        //list of orderIDs
        string address{get;set;}
        string cityName{get;set;}
        string stateName{get;set;}
        string zipCode{get;set;}

        List<String> productList = new List<String>();


    }
}