using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace Models
{
    public class Order
    {
        [Key]
        [Required]
        public int OrderId { get; set; }
        [ForeignKey("FK_OrderCust")]
        [Required]
        public int CustomerId { get; set; }
        [ForeignKey("FK_OrderLoc")]
        [Required]
        public int LocationId { get; set; }
        [Required]
        public decimal TotalCost { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Location Location { get; set; }
        public IEnumerable<OrderProduct> OrderProducts { get; set; }
    }
}
