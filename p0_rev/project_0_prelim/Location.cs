using System;
using System.Collections.Generic;

namespace project_0
{
    class Location
    {
        int locationID{get;set;}
        //list of available products
        //list of orderIDs
        string address{get;set;}
        string cityName{get;set;}
        string stateName{get;set;}
        string zipCode{get;set;}

        List<String> productList = new List<String>();

        public Location(int locationID, string address, string cityName, string stateName, string zipCode)
        {
            this.locationID = locationID;
            this.address = address;
            this.cityName = cityName;
            this.stateName = stateName;
            this.zipCode = zipCode;
        }


    }
}