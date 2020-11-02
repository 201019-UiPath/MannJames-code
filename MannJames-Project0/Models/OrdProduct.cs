using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class OrdProduct
    {
        public int OProductId;
        public int OrderId;
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
