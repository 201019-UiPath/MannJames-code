using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Order
    {
        int CustomerId;
        int OrderId;
        public List<OrdProduct> OProductList;

        public Order(int CustomerId, int OrderId, List<OrdProduct> OProductList)
        {
            this.CustomerId = CustomerId;
            this.OrderId = OrderId;
            this.OProductList = OProductList;
        }
        public override string ToString()
        {
            return $"{CustomerId} {OrderId} {OProductList}";
        }
    }
}
