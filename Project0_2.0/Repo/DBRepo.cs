using Models;
using System.Collections.Generic;

namespace Repos
{
    public class DBRepo : ICustomerRepo, IEmployeeRepo, IInventoryProductRepo,
        ILocationRepo, IOrderProductRepo, IOrderRepo
    {
        #region Customer
        public void AddCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public Customer GetCustomerById(int customerId)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Employee
        public void AddEmployee(Employee employee)
        {
            throw new System.NotImplementedException();
        }

        public List<Employee> GetAllEmployeesByLocation(int locationId)
        {
            throw new System.NotImplementedException();
        }

        public Employee GetEmployeeById(int employeeId)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region InventoryProduct
        public void AddProduct(InventoryProduct inventoryProduct)
        {
            throw new System.NotImplementedException();
        }

        public List<InventoryProduct> GetProducts(int locationId)
        {
            throw new System.NotImplementedException();
        }

        public InventoryProduct GetProductByName(string productName)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Location
        public void AddLocation(Location location)
        {
            throw new System.NotImplementedException();
        }

        public List<Location> GetAllLocations()
        {
            throw new System.NotImplementedException();
        }

        public Location GetLocationById(int locationId)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region OrderProduct
        public void AddProduct(OrderProduct orderProduct)
        {
            throw new System.NotImplementedException();
        }

        List<OrderProduct> IOrderProductRepo.GetProducts(int orderId)
        {
            throw new System.NotImplementedException();
        }

        OrderProduct IOrderProductRepo.GetProductByName(string productName)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Order
        public void AddOrder(Order order)
        {
            throw new System.NotImplementedException();
        }

        public List<Order> GetCustomerOrders(int customerId)
        {
            throw new System.NotImplementedException();
        }

        public List<Order> GetLocationOrders(int locationId)
        {
            throw new System.NotImplementedException();
        }
        #endregion



    }
}