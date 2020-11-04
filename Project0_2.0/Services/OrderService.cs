using Repos;
using System.Collections.Generic;
using Models;

namespace Services
{
    public class OrderService
    {
        private IOrderRepo repo;

        public OrderService(IOrderRepo repo)
        {
            this.repo = repo;
        }
        public void AddOrder(Order order)
        {
            repo.AddOrder(order);
        }
        public List<Order> GetCustomerOrders(int customerId)
        {
            return repo.GetCustomerOrders(customerId);
        }
        public List<Order> GetLocationOrders(int locationId)
        {
            return repo.GetLocationOrders(locationId);
        }
    }
}
