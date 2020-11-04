using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class OrdProduct
    {
        [Key]
        [Required]
        public int OProductId { get; set; }
        [ForeignKey("OrderProduct_FK")]
        [Required]
        public int OrderId { get; set; }
        [Required]
        public string OProductName { get; set; }
        public int Quantity { get; set; }
        public virtual Order Order { get; set; }

        public OrdProduct(int OProductId, int OrderId, string OProductName, int Quantity)
        {
            this.OProductId = OProductId;
            this.OrderId = OrderId;
            this.OProductName = OProductName;
            this.Quantity = Quantity;
        }
        public OrdProduct()
        {
            this.OProductId = 0;
            this.OrderId = 0;
            this.OProductName = null;
            this.Quantity = 0;
        }

        public override string ToString()
        {
            return $"{OProductName}";
        }
    }
}
