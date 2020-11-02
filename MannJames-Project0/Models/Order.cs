using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class Order
    {
        public int CustomerId;

        [Key]
        public int OrderId;

        public int LocationId;
        public virtual ICollection<OrdProduct> OProducts {get;set;}
      
        public Order(int CustomerId, int OrderId, int LocationId)
        {
            this.CustomerId = CustomerId;
            this.OrderId = OrderId;
            this.LocationId = LocationId;
           // this.OProductList = OProductList;
        }
        public override string ToString()
        {
            return $"{CustomerId} {OrderId} {LocationId}";
        }
    }
}
