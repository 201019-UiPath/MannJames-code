using Microsoft.EntityFrameworkCore;
using Models;
using Repos;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repo
{
    public class DBRepo : IRepository
    {
        public void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void AddCustomerAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        public void AddInventoryLineItem(InventoryProduct lineItem)
        {
            throw new NotImplementedException();
        }

        public void AddManager(Manager manager)
        {
            throw new NotImplementedException();
        }

        public void AddNewProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void AddNewProductToStock(int newProductId, int locationId)
        {
            throw new NotImplementedException();
        }

        public void AddOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public void AddOrderAsync(Order order)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAllCustomersAsync()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetAllEmployeesAsync()
        {
            throw new NotImplementedException();
        }

        public List<InventoryProduct> GetAllInventoryProductsAtLocation(int locationId)
        {
            throw new NotImplementedException();
        }

        public Task<List<InventoryProduct>> GetAllInventoryProductssAtLocationAsync(int locationId)
        {
            throw new NotImplementedException();
        }

        public List<Location> GetAllLocations()
        {
            throw new NotImplementedException();
        }

        public Task<List<Location>> GetAllLocationsAsync()
        {
            throw new NotImplementedException();
        }

        public List<Manager> GetAllManagers()
        {
            throw new NotImplementedException();
        }

        public Task<List<Manager>> GetAllManagersAsync()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOrdersForCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetAllOrdersForCustomerAsync(int customerID)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOrdersForLocation(int locationID)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetAllOrdersForLocationAsync(int locationId)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Manager GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeByIdAsync(int employeeId)
        {
            throw new NotImplementedException();
        }

        public Manager GetManagerByMId(int managerId)
        {
            throw new NotImplementedException();
        }

        public Task<Manager> GetManagerByMIdAsync(int managerId)
        {
            throw new NotImplementedException();
        }

        public List<OrderProduct> GetOrderedProductsInAnOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderProduct>> GetOrderedProductsInAnOrderAsync(int orderId)
        {
            throw new NotImplementedException();
        }

        public void RemoveInventoryLineItem(InventoryProduct lineItem)
        {
            throw new NotImplementedException();
        }

        public void RemoveInventoryProductFromLocation(InventoryProduct lineItem)
        {
            throw new NotImplementedException();
        }

        public void RemoveInventoryProductFromLocation(List<InventoryProduct> lineItems)
        {
            throw new NotImplementedException();
        }

        public void RemoveProductAtLocation(int removedProductId, int locationId)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void UpdateInventoryLineItem(InventoryProduct lineItem)
        {
            throw new NotImplementedException();
        }
    }
}