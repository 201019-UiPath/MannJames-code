using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace StoreDB
{
    public interface IInventoryRepo
    {
        void AddProduct(InvProduct invProduct);
        List<InvProduct> GetInvProducts();
        InvProduct GetInvByLocation(int locId);
    }
}
