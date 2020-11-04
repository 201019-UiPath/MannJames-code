using Models;
using System.Collections.Generic;

namespace Repos
{
    public interface IOrderRepo
    {
        void AddOrder(Order order);
        List<Order> GetCustomerOrders(int customerId);
        List<Order> GetLocationOrders(int locationId);
    }
}
