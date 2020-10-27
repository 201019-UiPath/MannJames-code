﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class OrdProduct
    {
        int OProductId;
        int OrderId;
        string OProductName;
        int Quantity;

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