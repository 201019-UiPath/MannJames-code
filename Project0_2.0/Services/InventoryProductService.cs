using Models;
using Repos;
using System.Collections.Generic;

namespace Services
{
    public class InventoryProductService
    {
        private IInventoryProductRepo repo;

        public InventoryProductService(IInventoryProductRepo repo)
        {
            this.repo = repo;
        }
        public void AddProduct(InventoryProduct inventoryProduct)
        {
            repo.AddProduct(inventoryProduct);
        }
        public List<InventoryProduct> GetProducts(int locationId)
        {
            List<InventoryProduct> getProducts = repo.GetProducts(locationId);
            return getProducts;
        }
        public InventoryProduct GetProductByName(string productName)
        {
            return repo.GetProductByName(productName);
        }
    }
}
