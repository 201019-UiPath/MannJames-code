using System.Collections.Generic;
using Models;

namespace Repos
{
    public interface IOrderProductRepo
    {
        void AddProduct(OrderProduct orderProduct);
        List<OrderProduct> GetProducts(int orderId);
        OrderProduct GetProductByName(string productName);
    }
}
