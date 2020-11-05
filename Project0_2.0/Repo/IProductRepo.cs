using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repos
{
    public interface IProductRepo
    {
        void AddNewProduct(Product product);

        void AddNewProductToStock(int newProductId, int locationId);

        void RemoveProductAtLocation(int removedProductId, int locationId);

        List<OrderProduct> GetOrderedProductsInAnOrder(int orderId);

        Task<List<OrderProduct>> GetOrderedProductsInAnOrderAsync(int orderId);

        List<Product> GetAllProducts();

        Task<List<Product>> GetAllProductsAsync();
    }
}