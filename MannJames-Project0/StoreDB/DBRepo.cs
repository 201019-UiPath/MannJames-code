using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreDB
{
    public class DBRepo : ICustomersRepo, IEmployeesRepo, 
        IInventoryRepo, ILocationRepo,IOrderRepo
    {
        private StoreDBContext context;
        public DBRepo(StoreDBContext context)
        {
            this.context = context;
        }

        public void AddCustomer(Customer customer)
        {
            context.Customer.AddAsync(customer);
            context.SaveChangesAsync();
        }

        public void AddEmployee(Employee employee)
        {
            context.Employee.AddAsync(employee);
            context.SaveChangesAsync();
        }

        public void AddManager(Manager manager)
        {
            context.Manager.AddAsync(manager);
            context.SaveChangesAsync();
        }

        public Task<List<Customer>> GetAllCustomers()
        {
            return context.Customer.Select(x => x)
                .ToListAsync();
        }

        public Customer GetCustomerById(int customerId)
        {
            return (Customer)context.Customer
                .Where(x => x.CustomerId == customerId);
        }

        public Customer GetCustomerByPhoneNumber(int phoneNumber)
        {
            return (Customer)context.Customer
                .Where(x => x.PhoneNumber == phoneNumber);
        }

        public Employee GetEmployeeById(int employeeId)
        {
            return (Employee)context.Employee
                .Where(x => x.EmployeeId == employeeId);
        }

        public Manager GetManagerByEId(int employeeId)
        {
            return (Manager)context.Manager
                .Where(x => x.EmployeeId == employeeId);
        }

        public Manager GetManagerByMId(int managerId)
        {
            return (Manager)context.Manager
                .Where(x => x.ManagerId == managerId);
        }

        public Task<List<Employee>> GetAllEmployees()
        {
            return context.Employee.Select(x => x)
                .ToListAsync();
        }

        public Task<List<Manager>> GetAllManagers()
        {
            return context.Manager.Select(x => x)
                .ToListAsync();
        }

        public Task<List<Employee>> GetEmployeesByLocation(int locId)
        {
            return context.Employee.Where(x => x.LocationId == locId)
                .ToListAsync();
        }

        public void AddProduct(InvProduct invProduct)
        {
            context.InvProducts.AddAsync(invProduct);
            context.SaveChangesAsync();
        }

        public Task<List<InvProduct>> GetInvProducts()
        {
            return context.InvProducts.Select(x => x)
                .ToListAsync();
        }

        public Task<List<InvProduct>> GetInvByLocation(int locId)
        {
            return context.InvProducts.Where(x => x.LocationId == locId)
                .ToListAsync();
        }

        public void AddLocation(Location location)
        {
            throw new System.NotImplementedException();
            context.InvProducts.AddAsync(invProduct);
            context.SaveChangesAsync();
        }

        public Task<List<Location>> GetAllLocations()
        {
            throw new System.NotImplementedException();
            return context.Customer.Select(x => x)
    .ToListAsync();
        }

        public Location GetLocationById(int locId)
        {
            throw new System.NotImplementedException();
            return (Manager)context.Manager
    .Where(x => x.ManagerId == managerId);
        }

        public void AddProduct(OrdProduct ordProduct)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<OrdProduct>> GetOrdProducts()
        {
            throw new System.NotImplementedException();
        }

        public void AddOrder(Order order)
        {
            throw new System.NotImplementedException();
        }

        public void AddOrdProduct(OrdProduct ordProduct)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Order>> GetOrdersByLocation(int locId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<OrdProduct>> GetProductsByOrder(int orderId)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Order>> GetOrdersByCustomer(int customerId)
        {
            throw new System.NotImplementedException();
        }
    }
}
