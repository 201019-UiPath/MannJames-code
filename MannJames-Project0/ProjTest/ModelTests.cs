using System;
using Xunit;
using Models;
using System.Collections.Generic;

//passed 6 of 6 tests
//need 4+ more

namespace ProjTest
{
    public class ModelTests
    {
        [Fact]
        public void CustomerTest()
        {
            //customer
            var customer = new Customer(1, "test", "testing", 2);
            Assert.NotNull(customer.ToString());
        }

        [Fact]
        public void EmployeeTest()
        {
            //employee
            var employee = new Employee(2, "testEmp", "testingEmp", 3);
            Assert.NotNull(employee.ToString());
        }

        [Fact]
        public void InvProdTest()
        {
            //invproduct
            var invproduct = new InvProduct(3, 4, "testInvProd", 5);
            Assert.NotNull(invproduct.ToString());
        }

        [Fact]
        public void LocationTest()
        {
            List<InvProduct> InvProdList = new List<InvProduct>()
            {
                new InvProduct(7,7,"spam",7),
                new InvProduct(9,9,"red fish", 9)
            };

                //location
                var location = new Location(5, "testLoc", "A", "B", 6, InvProdList);
            Assert.NotNull(location.ToString());
            }

        [Fact]
        public void OrderTest()
        {
            List<OrdProduct> OrderList = new List<OrdProduct>()
            {
                new OrdProduct(2,2,"blue fish",3),
                new OrdProduct(9,9,"two fish", 9)
            };

            //order
            var order = new Order(1,1, OrderList);
            Assert.NotNull(order.ToString());
        }

        [Fact]
        public void OrdProdTest()
        {
            //ordproduct
            var orderproduct = new OrdProduct(30, 20, "fishies", 10);
            Assert.NotNull(orderproduct.ToString());
        }
    }
}
