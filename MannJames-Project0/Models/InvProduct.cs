using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class InvProduct
    {
        int IProductId;
        int LocationId;
        string IProductName;
        int Quantity;

        public InvProduct(int IProductId, int LocationId, string IProductName, int Quantity)
        {
            this.IProductId = IProductId;
            this.LocationId = LocationId;
            this.IProductName = IProductName;
            this.Quantity = Quantity;
        }

        public override string ToString()
        {
            return $"{IProductId}, {LocationId}, {IProductName}, { Quantity}";
        }
    }
}
