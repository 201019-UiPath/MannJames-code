using System.Collections.Generic;
using System.Threading.Tasks;
using Models;
using StoreDB;

namespace BLL
{
    public class CustomerService
    {
        #region Customer
        private ICustomersRepo custRepo;
        public CustomerService(ICustomersRepo custRepo)
        {
            this.custRepo = custRepo;
        }
        public List<Customer> GetAllCustomers()
        {
            Task<List<Customer>> getCustomersTask = custRepo
                .GetAllCustomers();
            return getCustomersTask.Result;
        }
        public Customer GetCustomerById(int customerId)
        {
            return custRepo.GetCustomerById(customerId);
        }
        public Customer GetCustomerByPhoneNumber(int phoneNumber)
        {
            return custRepo
                .GetCustomerByPhoneNumber(phoneNumber);
        }
        public void AddCustomer(Customer customer)
        {
            custRepo.AddCustomer(customer);
        }
        #endregion
    }
}
