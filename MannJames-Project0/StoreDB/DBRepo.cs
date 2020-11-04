using Microsoft.EntityFrameworkCore;
using Models;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace StoreDB
{
    public class DBRepo : ICustomersRepo, IEmployeesRepo, 
        IInventoryRepo, ILocationRepo,IOrderRepo
    {
        private readonly StoreDBContext context;
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
            return context.Customer
                .Find(customerId);
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

        public void AddLocation(Location location)
        {
            context.Location.AddAsync(location);
            context.SaveChangesAsync();
        }

        public Task<List<Location>> GetAllLocations()
        {
            return context.Location.Select(x => x)
                .ToListAsync();
        }

        public void AddProduct(OrdProduct ordProduct)
        {
            context.OrdProduct.AddAsync(ordProduct);
            context.SaveChangesAsync();
        }

        public void AddOrder(Order order)
        {
            context.Order.AddAsync(order);
            context.SaveChangesAsync();
        }

        public Task<List<Order>> GetOrdersByLocation(int locId)
        {
            return context.Order.Where(x=>x.LocationId == locId)
                .ToListAsync();
        }


        public Task<List<OrdProduct>> GetProductsByOrder(int orderId)
        {
            return context.OrdProduct.Where(x => x.OrderId == orderId)
                .ToListAsync();
        }

        public Task<List<Order>> GetOrdersByCustomer(int customerId)
        {
            return context.Order.Where(x => x.CustomerId ==customerId )
                .ToListAsync();
        }

        public string GetInvProductById(int iProductId)
        {
            var name = (InvProduct)context.InvProducts
                .Where(x => x.IProductId == iProductId);
            string productName = name.ToString();
            return productName;
        }


        public List<InvProduct> GetInvByLocation(int locId)
        {
            return context.InvProducts
                .Where(x => x.LocationId == locId).ToList();
        }

        InvProduct IInventoryRepo.GetInvProductById(int iProductId)
        {
            throw new System.NotImplementedException();
        }

        void IInventoryRepo.EditProductAmnt(int productId, int quantity)
        {
            var product = context.InvProducts.Single(x => x.IProductId == productId);
            product.Quantity += quantity;
            context.SaveChangesAsync();
        }

        List<Order> IOrderRepo.GetOrderByDateEmployee(bool asc, int locId)
        {
            if(asc)
            {
                return context.Order.OrderBy(o => o.OrderDate)
                    .Where(o => o.LocationId == locId).ToList();
            }
            else
            {
                return context.Order.OrderByDescending(o => o.OrderDate).ToList();
            }
        }

        List<Order> IOrderRepo.GetOrderByDateCustomer(bool asc, int custId)
        {
            if (asc)
            {
                return context.Order.OrderBy(o => o.OrderDate)
                    .Where(o => o.LocationId == custId).ToList();
            }
            else
            {
                return context.Order.OrderByDescending(o => o.OrderDate).ToList();
            }
        }
    }
}
