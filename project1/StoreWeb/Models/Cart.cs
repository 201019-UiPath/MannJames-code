using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StoreWeb.Models
{
    public class Cart
    {
        [DataType(DataType.Currency)]
        public decimal TotalCost { get; set; }
        public List<CartItem> CartItems { get; set; }
        public Cart()
        {
            CartItems = new List<CartItem>();
        }
    }
}