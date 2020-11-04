using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class InventoryProduct
    {
        [Key]
        [Required]
        public int ProductId { get; set; }
        [ForeignKey("FK_ProductLocation")]
        [Required]
        public int LocationId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        public virtual Location Location { get; set; }
    }
}
