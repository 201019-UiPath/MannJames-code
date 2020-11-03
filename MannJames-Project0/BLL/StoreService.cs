using System.Collections.Generic;
using System.Threading.Tasks;
using Models;
using StoreDB;

namespace BLL
{
    public class StoreService
    {
        #region Customer
        private ICustomersRepo custRepo;
        public StoreService(ICustomersRepo custRepo)
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
            Customer resultCustomer = custRepo.GetCustomerById(customerId);
            return resultCustomer;
        }
        public Customer GetCustomerByPhoneNumber(int phoneNumber)
        {
            Customer resultCustomer = custRepo
                .GetCustomerByPhoneNumber(phoneNumber);
            return resultCustomer;
        }
        public void AddCustomer(Customer customer)
        {
            custRepo.AddCustomer(customer);
        }
        #endregion

        #region Employee
        private IEmployeesRepo empRepo;
        public StoreService(IEmployeesRepo empRepo)
        {
            this.empRepo = empRepo;
        }
        public void AddEmployee(Employee employee)
        {
            empRepo.AddEmployee(employee);
        }
        public List<Employee> GetAllEmployees()
        {
            Task<List<Employee>> getEmployeesTask = empRepo
                .GetAllEmployees();
            return getEmployeesTask.Result;
        }
        public Employee GetEmployeeById(int employeeId)
        {
            Employee resultEmployee = empRepo
                .GetEmployeeById(employeeId);
            return resultEmployee;
        }
        public List<Employee> GetEmployeesByLocation(int locId)
        {
            Task<List<Employee>> getEmployeesTask = empRepo
                .GetEmployeesByLocation(locId);
            return getEmployeesTask.Result;
        }
        #endregion

        #region Manager
        public void AddManager(Manager manager)
        {
            empRepo.AddManager(manager);
        }
        public List<Manager> GetAllManagers()
        {
            Task<List<Manager>> getEmployeesTask = empRepo
                    .GetAllManagers();
            return getEmployeesTask.Result;
        }
        public Manager GetManagerByMId(int managerId)
        {
            Manager resultEmployee = empRepo
                .GetManagerByMId(managerId);
            return resultEmployee;
        }
        public Manager GetManagerByEId(int employeeId)
        {
            Manager resultEmployee = empRepo
                .GetManagerByEId(employeeId);
            return resultEmployee;
        }
        #endregion
    }
}
