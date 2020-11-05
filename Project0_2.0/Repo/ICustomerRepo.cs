using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SufferShopDB.Repos
{
    public interface ICustomerRepo
    {
        /// <param name="customer"></param>
        void AddCustomerAsync(Customer customer);

        /// <param name="customer"></param>
        void AddCustomer(Customer customer);

        Task<List<Customer>> GetAllCustomersAsync();

        List<Customer> GetAllCustomers();

        /// <param name="customerID"></param>
        /// <returns></returns>
        List<Order> GetAllOrdersForCustomer(int customerId);

        /// <summary>
        /// This gets the order history of a specific customer, specified by that customer's ID, asynchronously.
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        Task<List<Order>> GetAllOrdersForCustomerAsync(int customerID);
    }
}