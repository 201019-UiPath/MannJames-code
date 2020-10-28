using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Order
    {
        int CustomerId;
        int OrderId;
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
