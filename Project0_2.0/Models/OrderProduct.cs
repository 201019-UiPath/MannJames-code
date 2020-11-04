using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class OrderProduct
    {
        [Key]
        [Required]
        public int ProductId { get; set; }
        [ForeignKey("FK_ProductOrder")]
        [Required]
        public int OrderId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }

        public virtual Order Order { get; set; }
    }
}
