using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace StoreDB
{
    public interface IOrderRepo
    {
        //creating order
        void AddProduct(OrdProduct ordProduct);
        List<OrdProduct> GetOrdProducts();

        //add order
        void AddOrder(Order order);
        void AddOrdProducts(OrdProduct ordProduct);

        //get orders
        Order GetOrdersByLocation(int locId);
        OrdProduct GetProductsByOrder(int orderId);
        Customer GetOrdersByCustomer(int customerId);
    }
}
