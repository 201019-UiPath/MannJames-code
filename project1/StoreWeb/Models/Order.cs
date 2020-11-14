using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoreWeb.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int LocationId { get; set; }
        public DateTime OrderDate { get; set; }

        [DataType(DataType.Currency)]
        public decimal TotalCost { get; set; }
        public User User { get; set; }
        public Location Location { get; set; }
        public List<LineItem> LineItems { get; set; }
    }
}