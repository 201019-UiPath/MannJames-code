using BLL;
using Models;
using StoreDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    public class ManagerMenu: IMenu
    {
        private string userInput1;
        private string userInput2;
        private StoreDBContext context;
        private IEmployeesRepo repo;
        private IMessagingService service;
        private EmployeeService employeeService;
        private MainMenu mainMenu;
        private int locationId;
        private IInventoryRepo inventoryRepo;
        private InventoryService inventoryService;

        public ManagerMenu(IEmployeesRepo repo,
            IMessagingService service)
        {
            this.service = service;
            this.employeeService = new EmployeeService(repo);
            this.inventoryService = new InventoryService(inventoryRepo);
        }
        public void Start()
        {
            do
            {
                Console.WriteLine("What is the location ID?");
                int locId = Int32.Parse(Console.ReadLine());
                List<InvProduct> products = inventoryService.GetInvByLocation(locId);
                foreach (var p in products)
                {
                    Console.WriteLine(p.ToString());
                }
                Console.WriteLine
                    ("Now to edit/add inventory by entering Product ID first");
                int productId = Int32.Parse(Console.ReadLine());
                userInput1 = Console.ReadLine();
                InvProduct product = new InvProduct();

                switch (userInput1)
                {
                    case "0":
                        Console.WriteLine("Product name");
                        product.IProductName = Console.ReadLine();
                        product.LocationId = locId;
                        Console.WriteLine("How many of them?");
                        product.Quantity = Int32.Parse(Console.ReadLine());
                        inventoryService.AddProduct(product);
                        mainMenu.Start();
                        break;
                    case "1":
                        Console.WriteLine("What is the product number?");
                        int productid = Int32.Parse(Console.ReadLine());
                        Console.WriteLine
                            ("Fix the quantity by using a positive number to add and negative number to reduce.");
                        Console.WriteLine("Example: 5 to add 5 and -5 to remove 5 from inventory");
                        int quantity = Int32.Parse(Console.ReadLine());
                        inventoryService.EditProductAmnt(productid, quantity);
                        mainMenu.Start();
                        break;
                    case "2":
                        Console.WriteLine("Bye for now!");
                        break;
                    default:
                        service.InvalidInputMessage();
                        break;
                }
            }
            while (!(userInput1.Equals("2")));
        }
    }
}
