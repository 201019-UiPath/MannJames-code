using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Order
    {
        [Key]
        [Required]
        public int OrderId { get; set; }

        [ForeignKey("Order_FK_Cust")]
        [Required]
        public int CustomerId { get; set; }
        [ForeignKey("Order_FK_Loc")]
        [Required]
        public int LocationId { get; set; }
        public virtual ICollection<OrdProduct> OProducts {get;set;}
        public virtual Customer Customer { get; set; }
        public virtual Location Location { get; set; }
      
        public Order(int CustomerId, int OrderId, int LocationId)
        {
            this.CustomerId = CustomerId;
            this.OrderId = OrderId;
            this.LocationId = LocationId;
           // this.OProductList = OProductList;
        }

        public Order()
        {
            this.CustomerId = 0;
            this.OrderId = 0;
            this.LocationId = 0;
        }
        public override string ToString()
        {
            return $"{CustomerId} {OrderId} {LocationId}";
        }
    }
}
