using System;
using StoreDB.Models;
using StoreLib;
using StoreDB.Repos;
using System.Collections.Generic;

namespace StoreUI.Menus.Customer
{
    class EditCartMenu : IMenu
    {
        private string userInput;
        private User loggedInUser;

        private ICartRepo cartRepo;
        private ICartItemRepo cartItemRepo;
        private IInventoryItemRepo inventoryItemRepo;
        private ILocationRepo locationRepo;
        private IProductRepo productRepo;
        private IUserRepo userRepo;

        private CartService cartService;
        private CartItemService cartItemService;
        private InventoryService inventoryService;
        private LocationService locationService;
        private ProductService productService;
        private UserService userService;

        public EditCartMenu(User user, StoreContext storeContext, ICartRepo cartRepo, 
            ICartItemRepo cartItemRepo,
            IInventoryItemRepo inventoryItemRepo, ILocationRepo locationRepo,
            IProductRepo productRepo, IUserRepo userRepo)
        {
            this.loggedInUser = user;
            this.cartRepo = cartRepo;
            this.cartItemRepo = cartItemRepo;
            this.inventoryItemRepo = inventoryItemRepo;
            this.locationRepo = locationRepo;
            this.productRepo = productRepo;
            this.userRepo = userRepo;

            this.cartService = new CartService(cartRepo);
            this.cartItemService = new CartItemService(cartItemRepo);
            this.inventoryService = new InventoryService(inventoryItemRepo);
            this.locationService = new LocationService(locationRepo);
            this.productService = new ProductService(productRepo);
            this.userService = new UserService(userRepo);
        }
        public void Start()
        {
            Cart cart = cartService.GetCartByUserId(loggedInUser.UserId);
            List<CartItem> items = cartItemService.GetAllCartItemsByCartId(cart.CartId);

            Console.WriteLine("\nItems currently in your cart: ");
            foreach (CartItem item in items)
            {
                Product product = productService.GetProductByProductId(item.ProductId);
                Console.WriteLine($" - {product.ProductName} | {product.Price} | {item.Quantity} ");
            }

            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("[1] Remove item");
            Console.WriteLine("[2] Change amount");
            Console.WriteLine("[3] Back");

            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    //TODO: Implement?
                    //Call from outside loop
                    //cartItemService.DeleteCartItem(product);
                    Console.WriteLine("Remove item selected");
                    break;

                case "2":
                    //TODO: Implement?
                    //cartItemService.EditCartItem(product);
                    Console.WriteLine("Change Item Quantity Selected");
                    break;

                case "3":
                    break;

                default:
                    ValidationService.InvalidInput();
                    break;
            }
        }

        public void RemoveItemFromCart()
        {
            string input;

            do
            {
                Console.WriteLine("\nSelect item to remove: ");

                Cart cart = cartService.GetCartByUserId(loggedInUser.UserId);
                List<CartItem> items = cartItemService.GetAllCartItemsByCartId(cart.CartId);
                int i = 0;
                foreach (CartItem item in items)
                {
                    i++;
                    Product product = productService.GetProductByProductId(item.ProductId);
                    Console.WriteLine(
                        $" [{i}] {product.ProductName} | {product.Price} | {item.Quantity} "
                    );
                }

                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    default:
                        ValidationService.InvalidInput();
                        break;
                }

            } while (!input.Equals("2"));

        }

        public void ChangeCartItemQuantity()
        {
            string input;

            do
            {
                Console.WriteLine("\nSelect item to adjust: ");

                Cart cart = cartService.GetCartByUserId(loggedInUser.UserId);
                List<CartItem> items = cartItemService.GetAllCartItemsByCartId(cart.CartId);
                int i = 0;
                foreach (CartItem item in items)
                {
                    i++;
                    Product product = productService.GetProductByProductId(item.ProductId);
                    Console.WriteLine($" [{i}] {product.ProductName} | {product.Price} | {item.Quantity} ");
                }

                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    default:
                        ValidationService.InvalidInput();
                        break;
                }

            } while (!input.Equals("2"));
        }
    }
}
