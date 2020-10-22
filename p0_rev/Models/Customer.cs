using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    class Customer
    {
        int customerID { get; set; }
        string firstName { get; set; }
        string lastName { get; set; }
        int phoneNumber { get; set; }

        public Customer(int customerID, string firstName, string lastName, int phoneNumber)
        {
            this.customerID = customerID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            Console.WriteLine($"{firstName}{lastName}" +
                $"{phoneNumber}");
        }

        //string paymentInfo{get;set;}

        //list of orders needed
        //customer can create order with multiple products
        //convert all products to lowercase
        //convert name to uppercase
        //write line using id to pull up orders

        //need library for products, orders, customers, and locations
        //list of locations
        //location selection yields product list
        //quantity, name and price

        //customer finds order history by giving name and phone number
        //customer can make order using name and phone number and location

        //manager view that can add products

        //users will be put as employees or customers

    }
}
