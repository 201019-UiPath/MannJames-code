using System;
using System.Collections.Generic;
using System.Text;
using BLL;
using StoreDB;

namespace UI
{
    public class MainMenu: IMenu
    {
        private string userInput;
        private CustomerMenu customerMenu;
        private EmployeeMenu employeeMenu;
        private LocationMenu locationMenu;
        private MessagingService service;
        public MainMenu(StoreDBContext context)
        {
            this.customerMenu = new CustomerMenu
                (new DBRepo(context));
            this.employeeMenu = new EmployeeMenu
                (new DBRepo(context), new MessagingService());
            this.locationMenu = new LocationMenu
                (new DBRepo(context), new MessagingService());
        }

        public void Start()
        {
            do
            {
                Console.WriteLine("Welcome! Please choose the numbered menu you want to view.");
                Console.WriteLine("[0] Our Locations and Products");
                Console.WriteLine("[1] Customer View");
                Console.WriteLine("[2] Employee View");
                Console.WriteLine("[3] Exit");
                userInput = Console.ReadLine();

                switch(userInput)
                {
                    case "0":
                        locationMenu.Start();
                        break;
                    case "1":
                        customerMenu.Start();
                        break;
                    case "2":
                        //employeeMenu.Start();
                        break;
                    case "3":
                        Console.WriteLine
                        (
                            "So long and thanks for all the fish!"
                        );
                        break;
                    default:
                        service.InvalidInputMessage();
                        break;
                }
            }
            while (!(userInput.Equals("3")));
        }
    }
}
