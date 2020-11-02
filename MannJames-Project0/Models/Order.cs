using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Order
    {
        public int CustomerId;
        public int OrderId;
        public virtual ICollection<OrdProduct> OProducts {get;set;}
      
        public Order(int CustomerId, int OrderId)
        {
            this.CustomerId = CustomerId;
            this.OrderId = OrderId;
           // this.OProductList = OProductList;
        }
        public override string ToString()
        {
            return $"{CustomerId} {OrderId}";
        }
    }
}
