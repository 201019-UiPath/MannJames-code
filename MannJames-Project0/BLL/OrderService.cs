using Models;
using StoreDB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderService
    {
        private IOrderRepo orderRepo;
        public OrderService(IOrderRepo orderRepo)
        {
            this.orderRepo = orderRepo;
        }
        public void AddOrder(Order order)
        {
            orderRepo.AddOrder(order);
        }
        public void AddProduct(OrdProduct ordProduct)
        {
            orderRepo.AddProduct(ordProduct);
        }
        public List<Order> GetOrdersByLocation(int locId)
        {
            Task<List<Order>> getOrdersTask = orderRepo
                .GetOrdersByLocation(locId);
            return getOrdersTask.Result;

        }
        public List<OrdProduct> GetProductsByOrder(int orderId)
        {
            Task<List<OrdProduct>> getOrderProductsTask = orderRepo
                .GetProductsByOrder(orderId);
            return getOrderProductsTask.Result;
        }
        public List<Order> GetOrdersByCustomer(int customerId)
        {
            Task<List<Order>> getOrdersTask = orderRepo
                .GetOrdersByCustomer(customerId);
            return getOrdersTask.Result;
        }
    }
}
