using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace StoreDB
{
    public interface ICustomersRepo
    {
        Task<List<Customer>> GetAllCustomers();
        Customer GetCustomerById(int customerId);
        Customer GetCustomerByPhoneNumber(int phoneNumber);
        void AddCustomer(Customer customer);
    }
}
