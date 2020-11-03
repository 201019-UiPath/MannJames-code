using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    public class ReturnCustomerMenu : IMenu
    {
        private string userInput;

/*        public MainMenu(StoreDBContext context)
        {
            this.customerMenu = new CustomerMenu(new DBRepo(context), new MessagingService());
            this.employeeMenu = new EmployeeMenu(new DBRepo(context), new MessagingService());
            this.locationMenu = new LocationMenu(new DBRepo(context), new MessagingService());

        }*/

        public void Start()
        {
            do
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("[0] Make Order");
                Console.WriteLine("[1] View Past Orders");
                Console.WriteLine("[2] Exit");

                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        //create order
                        break;
                    case "1":
                        //view orders
                        break;
                    case "2":
                        Console.WriteLine("Thank you for visiting! Until next time!");
                        break;
                    default:
                        break;
                }
            }
            while (!(userInput.Equals("3"))) ;
        }
    }
}
