using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDB
{
    public interface ICustomersRepo
    {
        void AddCustomer(Customer customer);
        List<Customer> GetAllCustomers();
        Customer GetCustomerById(int customerId);
        Customer GetCustomerByPhoneNumber(int phoneNumber);
        List<Customer> GetCustomersByName(string firstName, string lastName);
    }
}
