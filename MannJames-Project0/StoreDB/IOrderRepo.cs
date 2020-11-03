using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Utilities;
using Models;

namespace StoreDB
{
    public interface IOrderRepo
    {
        //add order
        void AddOrder(Order order);
        void AddProduct(OrdProduct ordProduct);

        //get orders
        Task<List<Order>> GetOrdersByLocation(int locId);
        Task<List<OrdProduct>> GetProductsByOrder(int orderId);
        Task<List<Order>> GetOrdersByCustomer(int customerId);
    }
}
