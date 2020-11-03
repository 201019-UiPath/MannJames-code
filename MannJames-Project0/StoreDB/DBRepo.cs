using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StoreDB
{
    public class DBRepo : //ICustomersRepo, //IEmployeesRepo,
        IInventoryRepo, ILocationRepo, IOrderRepo
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

        public void AddLocation(Location location)
        {
            context.Location.AddAsync(location);
            context.SaveChangesAsync();
        }

        public void AddOrder(Order order)
        {
            context.Order.AddAsync(order);
            context.SaveChangesAsync();
        }

        public void AddOrdProducts(OrdProduct ordproduct)
        {
            context.OrdProduct.AddAsync(ordproduct);
            context.SaveChangesAsync();
        }

        public void AddProduct(InvProduct invProduct)
        {
            context.InvProducts.AddAsync(invProduct);
            context.SaveChangesAsync();
        }

        public void AddProduct(OrdProduct ordProduct)
        {
            context.OrdProduct.AddAsync(ordProduct);
            context.SaveChangesAsync();
        }

        public List<Customer> GetAllCustomers()
        {
            return context.Customer.Select(x => x)
                .ToList();
        }

        public List<Employee> GetAllEmployees()
        {
            return context.Employee.Select(x => x)
                .ToList();
        }

        public List<Location> GetAllLocations()
        {
            return context.Location.Select(x => x)
                .ToList();
        }

        public Customer GetCustomerById(int customerId)
        {
            return (Customer)context.Customer
                .Where(x => x.CustomerId == customerId);
        }

/*        public List<Customer> GetCustomersByName(string firstName, 
            string lastName)
        {
            return (Customer)context.Customer
                .Where(x => x.FirstName == firstName, lastName);
        }*/

        public Customer GetCustomerByPhoneNumber(int phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Customer GetEmployeeByLocation(int locId)
        {
            throw new NotImplementedException();
        }

/*        public Customer GetEmployeeByName(string firstName, string lastName)
        {
//
        }*/

        public InvProduct GetInvByLocation(int locId)
        {
            throw new NotImplementedException();
        }

        public List<InvProduct> GetInvProducts()
        {
            return context.InvProducts.Select(x => x)
                .ToList();
        }

        public Location GetLocationById(int locId)
        {
            throw new NotImplementedException();
        }

        public Customer GetOrdersByCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public Order GetOrdersByLocation(int locId)
        {
            throw new NotImplementedException();
        }

        public List<OrdProduct> GetOrdProducts()
        {
            return context.OrdProduct.Select(x => x)
                .ToList();
        }

        public OrdProduct GetProductsByOrder(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
