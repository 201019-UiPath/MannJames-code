using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using Xunit;
using BLL;

namespace ProjTest
{
    public class BLLTest
    {
        
        private CustomerService customerService;
        private EmployeeService employeeService;
        private LocationService locationService;
        [Fact]
        public void TestGetAllCustomers()
        {
            Assert.NotNull(customerService.GetAllCustomers());
        }
        [Fact]
        public void TestGetAllEmployees()
        {
            Assert.NotNull(employeeService.GetAllEmployees());
        }
        [Fact]
        public void TestGetAllLocations()
        {
            Assert.NotNull(locationService.GetAllLocations());
        }
    }
}
