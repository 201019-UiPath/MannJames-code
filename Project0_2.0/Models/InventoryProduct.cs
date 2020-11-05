using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class InventoryProduct
    {
        private int productQuantity;

        [Key]
        [Required]
        public int ProductId { get; set; }
        [ForeignKey("FK_ProductLocation")]
        [Required]
        public int LocationId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public virtual Location Location { get; set; }
        public virtual Product Product { get; set; }
        internal InventoryProduct
            (int productId, int locationId, int quantity)
        {
            ProductId = productId;
            LocationId = locationId;
            Quantity = quantity;
        }
        public InventoryProduct
            (Location location, Product product, int quantity):
            this(location.LocationId,product.ProductId,quantity)
        {
            Product = product;
            Location = location;
        }
    }
}
