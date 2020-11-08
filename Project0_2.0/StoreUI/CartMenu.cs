﻿using System;
using StoreDB;
using StoreDB.Models;
using StoreLib;
using StoreDB.Repos;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace StoreUI.Menus.Customer
{
    public class CartMenu : IMenu
    {
        private string userInput;
        private User loggedInUser;

        private ICartRepo cartRepo;
        private ICartItemRepo cartItemRepo;
        private IInventoryItemRepo inventoryItemRepo;
        private ILineItemRepo lineItemRepo;
        private ILocationRepo locationRepo;
        private IOrderRepo orderRepo;
        private IProductRepo productRepo;
        private IUserRepo userRepo;

        private CartService cartService;
        private CartItemService cartItemService;
        private InventoryService inventoryService;
        private LineItemService lineItemService;
        private LocationService locationService;
        private OrderService orderService;
        private ProductService productService;
        private UserService userService;

        private EditCartMenu editCartMenu;

        public CartMenu(User user, StoreContext storeContext, ICartRepo cartRepo, ICartItemRepo cartItemRepo,
            IInventoryItemRepo inventoryItemRepo, ILineItemRepo lineItemRepo, ILocationRepo locationRepo,
            IOrderRepo orderRepo, IProductRepo productRepo, IUserRepo userRepo)
        {
            this.loggedInUser = user;
            this.cartRepo = cartRepo;
            this.cartItemRepo = cartItemRepo;
            this.inventoryItemRepo = inventoryItemRepo;
            this.lineItemRepo = lineItemRepo;
            this.locationRepo = locationRepo;
            this.orderRepo = orderRepo;
            this.productRepo = productRepo;
            this.userRepo = userRepo;

            this.cartService = new CartService(cartRepo);
            this.cartItemService = new CartItemService(cartItemRepo);
            this.inventoryService = new InventoryService(inventoryItemRepo);
            this.lineItemService = new LineItemService(lineItemRepo);
            this.locationService = new LocationService(locationRepo);
            this.orderService = new OrderService(orderRepo);
            this.productService = new ProductService(productRepo);
            this.userService = new UserService(userRepo);

            this.editCartMenu = new EditCartMenu(
                loggedInUser, storeContext, new DBRepo(storeContext), new DBRepo(storeContext),
                new DBRepo(storeContext), new DBRepo(storeContext), new DBRepo(storeContext),
                new DBRepo(storeContext)
            );
        }

        public void Start()
        {
            StoreContext storeContext = new StoreContext();
            CustomerMenu customerMenu = new CustomerMenu(loggedInUser, storeContext);

            do
            {
                Cart cart = cartService.GetCartByUserId(loggedInUser.UserId);
                if (cart == null) 
                {

                    /* Console.WriteLine("Cart is empty!");
                      StoreContext context = new StoreContext();
                      CustomerMenu customerM = new CustomerMenu(loggedInUser, context);
                      customerM.Start();*/
                    Cart cartToAdd = new Cart();
                    cartToAdd.UserId = loggedInUser.UserId;

                    cartService.AddCart(cartToAdd);
                    Console.WriteLine("Cart is empty! We will make one for you!");
                    StoreContext context = new StoreContext();
                    CustomerMenu customerM = new CustomerMenu(loggedInUser, context);
                    customerM.Start();
                }

                List<CartItem> items = cartItemService.GetAllCartItemsByCartId(cart.CartId);
                foreach (CartItem item in items)
                {
                    Product product = productService.GetProductByProductId(item.ProductId);
                    Console.WriteLine($" - {product.ProductName} | {product.Price} | {item.Quantity}");
                }

                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("[1] Checkout");
                Console.WriteLine("[2] Edit cart");
                Console.WriteLine("[3] Back");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CheckOut();
                        break;

                    case "2":
                        editCartMenu.Start();
                        break;

                    case "3":
                        break;

                    default:
                        ValidationService.InvalidInput();
                        break;
                }
            } while (!userInput.Equals("3"));
        }

        public void CheckOut()
        {
            Cart cart = cartService.GetCartByUserId(loggedInUser.UserId);
            List<CartItem> items = cartItemService.GetAllCartItemsByCartId(cart.CartId);

            Order order = new Order();
            double total = 0;
            order.UserId = loggedInUser.UserId;
            order.LocationId = loggedInUser.LocationId;
            DateTime orderDate = order.OrderDate = DateTime.Now;
            orderService.AddOrder(order);

            Order createdOrder = orderService.GetOrderByDate(orderDate);

            Console.WriteLine("\nYour order has been placed.");
            Console.WriteLine("Here is your receipt:");

            foreach (CartItem item in items)
            {
                Product product = productService.GetProductByProductId(item.ProductId);

                LineItem lineItem = new LineItem();
                lineItem.OrderId = createdOrder.OrderId;
                lineItem.ProductId = item.ProductId;
                lineItem.Price = product.Price;
                lineItem.Quantity = item.Quantity;
                
                //salestax
                float salestax = 1.07F;

                //had to convert numbers to float...keep an eye on this
                total += product.Price * item.Quantity * salestax;

                lineItemService.AddLineItem(lineItem);

                cartItemService.DeleteCartItem(item);

                InventoryItem itemInInv = inventoryService.GetItemByLocationIdProductId
                (
                    loggedInUser.LocationId, product.ProductId
                );
                itemInInv.Quantity -= item.Quantity;
                inventoryService.UpdateInventoryItem(itemInInv);

                Console.WriteLine($"Item: {product.ProductName} {product.Price} {lineItem.Quantity}");
            }

            //Update order's total price
            order.TotalPrice = total;
            orderService.UpdateOrder(createdOrder);

            Console.WriteLine($"Your total: {order.TotalPrice}");
            Console.WriteLine("Thank you for visiting Mann's Videogame Shoppe!");
            cartRepo.DeleteCart(cart);
        }
    }
}
