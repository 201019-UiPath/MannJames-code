using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class InvProduct
    {
        [Key]
        [Required]
        public int IProductId { get; set; }
        [Required]
        [ForeignKey("FK_Inventory")]
        public int LocationId { get; set; }
        [Required]
        public string IProductName { get; set; }
        public int Quantity { get; set; }
        public virtual Location Location { get; set; }

        public InvProduct(int IProductId, int LocationId, string IProductName, int Quantity)
        {
            this.IProductId = IProductId;
            this.LocationId = LocationId;
            this.IProductName = IProductName;
            this.Quantity = Quantity;
        }

        public InvProduct()
        {
            this.IProductId = 0;
            this.LocationId = 0;
            this.IProductName = null;
            this.Quantity = 999;
        }

        public override string ToString()
        {
            return $"{IProductId}, {LocationId}, {IProductName}, {Quantity}";
        }
    }
}
