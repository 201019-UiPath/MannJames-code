using System.Collections.Generic;
using Models;
using Repos;

namespace Services
{
    public class OrderProductService
    {
        private IOrderProductRepo repo;

        public OrderProductService(IOrderProductRepo repo)
        {
            this.repo = repo;
        }
        public void AddProduct(OrderProduct orderProduct)
        {
            repo.AddProduct(orderProduct);
        }
        public List<OrderProduct> GetProducts(int orderId)
        {
            return repo.GetProducts(orderId);
        }
        public OrderProduct GetProductByName(string productName)
        {
            return repo.GetProductByName(productName);
        }
    }
}
