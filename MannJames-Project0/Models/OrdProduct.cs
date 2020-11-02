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
        public int OProductId;
        [ForeignKey("OrderProduct_FK")]
        [Required]
        public int OrderId;
        [Required]
        public string OProductName;
        public int Quantity;
        public virtual Order Order { get; set; }

        public OrdProduct(int OProductId, int OrderId, string OProductName, int Quantity)
        {
            this.OProductId = OProductId;
            this.OrderId = OrderId;
            this.OProductName = OProductName;
            this.Quantity = Quantity;
        }

        public override string ToString()
        {
            return $"{OProductId}, {OrderId}, {OProductName}, { Quantity}";
        }
    }
}
