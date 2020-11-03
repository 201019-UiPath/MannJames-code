using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDB
{
    public class DBRepo : ICustomersRepo, IEmployeesRepo,
        IInventoryRepo, ILocationRepo, IOrderRepo, IPaymentRepo,
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

        public void AddPayment(CardPayment cardPayment)
        {
            context.CardPayment.AddAsync(cardPayment);
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
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public List<Location> GetAllLocations()
        {
            throw new NotImplementedException();
        }

        public List<CardPayment> GetCardPayments(int customerId)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int customerId)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerByName(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

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

        public Customer GetEmployeeByName(string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        public InvProduct GetInvByLocation(int locId)
        {
            throw new NotImplementedException();
        }

        public List<InvProduct> GetInvProducts()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public OrdProduct GetProductsByOrder(int orderId)
        {
            throw new NotImplementedException();
        }
    }
}
