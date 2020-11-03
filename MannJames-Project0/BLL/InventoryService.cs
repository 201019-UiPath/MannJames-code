using Models;
using StoreDB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL
{
    public class InventoryService
    {
        private IInventoryRepo inventoryRepo;
        public InventoryService(IInventoryRepo inventoryRepo)
        {
            this.inventoryRepo = inventoryRepo;
        }
        public void AddProduct(InvProduct invProduct)
        {
            inventoryRepo.AddProduct(invProduct);
        }
        public List<InvProduct> GetInvProducts()
        {
            Task<List<InvProduct>> getProductsTask =
                inventoryRepo.GetInvProducts();
            return getProductsTask.Result;
        }
        //invproduct getinvprod by loc
        public List<InvProduct> GetInvByLocation(int locId)
        {
            Task<List<InvProduct>> getProductsTask =
                inventoryRepo.GetInvByLocation(locId);
            return getProductsTask.Result;
        }
    }
}
