using System.Collections.Generic;

namespace StoreWeb.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string StreetNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public List<Inventory> Inventory { get; set; }
    }
}