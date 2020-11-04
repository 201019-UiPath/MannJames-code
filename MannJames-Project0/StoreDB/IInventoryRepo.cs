using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace StoreDB
{
    public interface IInventoryRepo
    {
        void AddProduct(InvProduct invProduct);
        Task<List<InvProduct>> GetInvProducts();
        public List<InvProduct> GetInvByLocation(int locId);
        InvProduct GetInvProductById(int iProductId);
    }
}
