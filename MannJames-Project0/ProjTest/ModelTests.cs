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
                var location1 = new Location(5, "testLoc", "A", "B", 33006,"hours","number");
                Assert.NotNull(location1.ToString());
                var location2 = new Location(10, "testLoc", "d", "c", 33011, "hours", "number");
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
            //var order = new Order(1,1);
           // Assert.NotNull(order.ToString());
        }

        [Fact]
        public void OrdProdTest()
        {
            //ordproduct
            var orderproduct = new OrdProduct(30, 20, "fishies", 10);
            Assert.NotNull(orderproduct.ToString());
        }

        [Fact]
        public void CardTest()
        {
            //ordproduct
            var cardpayment = new CardPayment(1234567890, 1, 123, "12/31/2020",
            "11001 NW 25 ST", "Coral Springs", "FL", 33076);
            Assert.NotNull(cardpayment.ToString());
        }

        [Fact]
        public void EmployeeLogin()
        {
           // var employeelogin = new EmployeeLogin(1,"Manager","password1");
           // Assert.NotNull(employeelogin.ToString());
        }

        [Fact]
        public void CustomerLogin()
        {
           // var customerlogin = new CustomerLogin(2, "password2");
           // Assert.NotNull(customerlogin.ToString());
        }
    }
}
