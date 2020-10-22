using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
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
        }

        public Location()
        {
            this.locationID = 0;
            this.address = null;
            this.cityName = null;
            this.stateName = null;
            this.zipCode = null;
        }
    }
}
