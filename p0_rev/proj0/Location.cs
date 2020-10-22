using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static project0.Product;

namespace project0
{
    public class Location
    {
        int locationID { get; set; }
        string address { get; set; }
        string cityName { get; set; }
        string stateName { get; set; }
        string zipCode { get; set; }

        public Location(int locationID, string address, string cityName, string stateName, string zipCode)
        {
            this.locationID = locationID;
            this.address = address;
            this.cityName = cityName;
            this.stateName = stateName;
            this.zipCode = zipCode;

            Console.WriteLine($"{address} {cityName} " +
                $"{stateName} {zipCode}");
        }
    }
}
