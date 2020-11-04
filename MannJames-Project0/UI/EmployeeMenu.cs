using System;
using System.Collections.Generic;
using System.Text;
using Models;
using BLL;
using StoreDB;

namespace UI
{
    public class EmployeeMenu : IMenu
    {
        private string userInput;
        private StoreDBContext context;
        private IEmployeesRepo repo;
        private IMessagingService service;
        private EmployeeService employeeService;
        private MainMenu mainMenu;
        private int locationId;
        private OrderService orderService;
        private IOrderRepo orderRepo;
        private ManagerMenu managerMenu;

        public EmployeeMenu(IEmployeesRepo repo,
            IMessagingService service)
        {
            this.service = service;
            this.employeeService = new EmployeeService(repo);
            this.orderService = new OrderService(orderRepo);
        }
        public void Start()
        {
            do
            {
                Console.WriteLine("What is your LocationId?");
                int locId = Int32.Parse(Console.ReadLine());
                List<Employee> employees = employeeService.GetEmployeesByLocation(locId);
                foreach (var e in employees)
                {
                    Console.WriteLine(e.ToString());
                }

                Console.WriteLine("Pick a number!");
                Console.WriteLine("[0] Back please!");
                Console.WriteLine("[1] View Orders");
                Console.WriteLine("[2] Go to Manager Portal");
                Console.WriteLine("[3] Exit");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        mainMenu.Start();
                        break;
                    case "1":
                        orderRepo.GetOrdersByLocation(locId);
                        break;
                    case "2":
                        managerMenu.Start();
                        break;
                    case "3":
                        Console.WriteLine("Bye for now!");
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
