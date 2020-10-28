﻿using System;
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
