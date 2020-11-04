using BLL;
using Models;
using StoreDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI
{
    public class LocationMenu: IMenu
    {
        private string userInput;
        private StoreDBContext context;
        private ILocationRepo locationRepo;
        private IMessagingService service;
        private LocationService locService;
        private MainMenu mainMenu;
        private InventoryService invService;
        private IInventoryRepo inventoryRepo;
        private int locationId;

        public LocationMenu(ILocationRepo locationRepo,
            IMessagingService service)
        {
            this.service = service;
            this.locService = new LocationService(locationRepo);
            this.invService = new InventoryService(inventoryRepo);
        }

        public void Start()
        {
            do
            {
                Console.WriteLine("What location number do you want to look at?");
                locService.GetAllLocations();
                List<Location> locations = locService.GetAllLocations();
                foreach (var l in locations)
                {
                    Console.WriteLine(l.ToString());
                }
                locationId = Int32.Parse(Console.ReadLine());

                invService.GetInvByLocation(locationId);
                //List<InvProduct> products = invService.GetInvProducts();
/*                foreach (var p in products)
                {
                    Console.WriteLine(p.ToString());
                }*/
                Console.WriteLine("Pick a number!");
                Console.WriteLine("[0] Back please!");
                Console.WriteLine("[1] Exit");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "0":
                        mainMenu.Start();
                        break;
                    case "1":
                        Console.WriteLine("Bye for now!");
                        break;
                    default:
                        service.InvalidInputMessage();
                        break;
                }
            }

            while (!(userInput.Equals("1")));

        }
    }
}
