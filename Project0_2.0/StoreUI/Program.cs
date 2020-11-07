using StoreDB;
using StoreDB.Models;
using StoreUI.Menus;
using StoreUI.Menus.Customer;

namespace StoreUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //need to fix to go to main menu
            User user = new User();
            user.UserId = 1;
            StoreContext context = new StoreContext();
            IMenu startMenu = new CustomerMenu(user, context);
            startMenu.Start();
        }
    }
}
