using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    public class Location
    {
        public int LocationID { get; set; }
        public string Address { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }
        public string ZipCode { get; set; }

        public Location(int LocationID, string Address, string CityName, 
            string StateName, string ZipCode)
        {
            this.LocationID = LocationID;
            this.Address = Address;
            this.CityName = CityName;
            this.StateName = StateName;
            this.ZipCode = ZipCode;
        }

        public Location()
        {
            this.LocationID = 0;
            this.Address = null;
            this.CityName = null;
            this.StateName = null;
            this.ZipCode = null;
        }

        public override string ToString()
        {
            string output = "";
            output += $"{LocationID} {Address} {CityName} {StateName} {ZipCode}";
            return output;
        }
    }
}
