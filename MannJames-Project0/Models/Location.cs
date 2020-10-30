using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Models
{
    public class Location
    {
        public int LocationId { get; set;}
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public string Hours { get; set; }
        
        public virtual ICollection<InvProduct> IProducts { get; set; }
        //employees
        public virtual ICollection<Employee> Employees { get; set; }


        public Location(int LocationId, string Address, string City, string State, 
            int ZipCode, string Hours)
        {
            this.LocationId = LocationId;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
            this.Hours = Hours;
        }

        public Location()
        {
            this.LocationId = 0;
            this.Address = null;
            this.City = null;
            this.State = null;
            this.ZipCode = 00000;
            this.Hours = null;
        }

        public override string ToString()
        {
            return $"{LocationId} {Address} {City} {State} {ZipCode} {Hours}";
        }
    }
}
