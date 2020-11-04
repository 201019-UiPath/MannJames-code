using Models;

namespace Repos
{
    public interface ICustomerRepo
    {
        void AddCustomer(Customer customer);
        Customer GetCustomerById(int customerId);
    }
}
