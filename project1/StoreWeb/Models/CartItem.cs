using System.ComponentModel;

namespace StoreWeb.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }

        [DisplayName("Quantity")]
        public int Quantity { get; set; }

        public Product Product { get; set; }
    }
}
