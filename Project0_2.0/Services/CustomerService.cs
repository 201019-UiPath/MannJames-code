using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Models;
using Repos;

namespace Services
{
    public class CustomerService
    {
        private ICustomerRepo repo;

        public CustomerService(ICustomerRepo repo)
        {
            this.repo = repo;
        }

        public void AddCustomer(Customer customer)
        {
            repo.AddCustomer(customer);
        }

        public Customer GetCustomerById(int customerId)
        {
            return repo.GetCustomerById(customerId);
        }
    }
}
