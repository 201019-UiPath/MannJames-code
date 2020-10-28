using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Models
{
    public class Location
    {
        int LocationId { get; set;}
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        int ZipCode { get; set; }
        //inventory
        public virtual ICollection<InvProduct> IProducts { get; set; }
        //employees
        public virtual ICollection<Employee> Employees { get; set; }


        public Location(int LocationId, string Address, string City, string State, int ZipCode)
        {
            this.LocationId = LocationId;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
            //this.IProductList = IProductList;
        }

        public override string ToString()
        {
            return $"{LocationId} {Address} {City} {State} {ZipCode}";
        }
    }
}
