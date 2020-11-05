using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Repos
{
    public interface IOrderRepo
    {
        /// <param name="order"></param>
        void AddOrder(Order order);
        void AddOrderAsync(Order order);
        /// <param name="locationId"></param>
        /// <returns></returns>
        Task<List<Order>> GetAllOrdersForLocationAsync(int locationId);
        List<Order> GetAllOrdersForLocation(int locationID);
        void RemoveInventoryProductFromLocation(InventoryProduct lineItem);
        void RemoveInventoryProductFromLocation
            (List<InventoryProduct> lineItems);
    }
}
