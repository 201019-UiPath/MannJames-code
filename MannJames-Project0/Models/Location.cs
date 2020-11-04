using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Text;

namespace Models
{
    public class Location
    {
        [Required]
        [Key]
        public int LocationId { get; set;}
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public int ZipCode { get; set; }
        [Required]
        public string Hours { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public virtual ICollection<InvProduct> InvProducts { get; set; }
        //employees
        public virtual ICollection<Employee> Employees { get; set; }


        public Location(int LocationId, string Address, string City, string State, 
            int ZipCode, string Hours, string PhoneNumber)
        {
            this.LocationId = LocationId;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.ZipCode = ZipCode;
            this.Hours = Hours;
            this.PhoneNumber = PhoneNumber;
        }

        public Location()
        {
            this.LocationId = 0;
            this.Address = null;
            this.City = null;
            this.State = null;
            this.ZipCode = 10000;
            this.Hours = null;
            this.PhoneNumber = null;
        }

        public override string ToString()
        {
            return $"{LocationId} {Address} {City} {State} {ZipCode} {Hours} {PhoneNumber}";
        }
    }
}
