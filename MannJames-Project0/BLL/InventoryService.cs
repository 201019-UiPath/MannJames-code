using Models;
using StoreDB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL
{
    public class InventoryService
    {
        private IInventoryRepo repo;
        public InventoryService(IInventoryRepo repo)
        {
            this.repo = repo;
        }
        public void AddProduct(InvProduct invProduct)
        {
            repo.AddProduct(invProduct);
        }
        public List<InvProduct> GetInvProducts()
        {
            Task<List<InvProduct>> getProductsTask =
                repo.GetInvProducts();
            return getProductsTask.Result;
        }
        public List<InvProduct> GetInvByLocation(int locId)
        {
            return repo
                .GetInvByLocation(locId);
        }
        public string GetInvProductById(int iProductId)
        {
            var productVar = repo.GetInvProductById(iProductId);
            string productName = productVar.ToString();
            return productName;
        }
    }
}
