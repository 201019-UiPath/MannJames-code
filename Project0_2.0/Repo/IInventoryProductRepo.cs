using Models;
using System.Collections.Generic;

namespace Repos
{
    public interface IInventoryProductRepo
    {
        void AddProduct(InventoryProduct inventoryProduct);
        List<InventoryProduct> GetProducts(int locationId);
        InventoryProduct GetProductByName(string productName);
    }
}
