﻿using StoreDB.Models;
using StoreDB.Repos;
using System.Collections.Generic;
using System.Linq;

namespace StoreDB
{
    public class DBRepo : IProductRepo, ILocationRepo, IInventoryItemRepo, 
        ICartItemRepo, ICartRepo
    {
        private StoreContext context;
        public DBRepo(StoreContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Methods to affect product
        /// </summary>
        /// <param name="product"></param>

        public void AddProduct(Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
        }

        public List<Product> GetAllProducts()
        {
            return context.Products.Select(x => x).ToList();
        }

        public Product GetProductById(int productId)
        {
            return context.Products.Single(x => x.ProductId == productId);
        }

        public Product GetProductByName(string productName)
        {
            return context.Products.Single(x => x.ProductName == productName);
        }

        public void UpdateProduct(Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
        }

        /// <summary>
        /// Manipulate Location Info
        /// </summary>
        /// <param name="location"></param>

        public void AddLocation(Location location)
        {
            context.Locations.Add(location);
            context.SaveChanges();
        }

        public void DeleteLocation(Location location)
        {
            context.Locations.Remove(location);
            context.SaveChanges();
        }
        public List<Location> GetAllLocations()
        {
            return context.Locations.Select(x => x).ToList();
        }

        public void UpdateLocation(Location location)
        {
            context.Locations.Update(location);
        }

        public List<Location> GetLocationByState(string state)
        {
            return context.Locations.Where(x => x.State == state).ToList();
        }

        public List<Location> GetLocationByCity(string city)
        {
            return context.Locations.Where(x => x.City == city).ToList();
        }

        public List<Location> GetLocationByZipcode(string zipcode)
        {
            return context.Locations.Where(x => x.ZipCode == zipcode).ToList();
        }

        public Location GetLocationById(int id)
        {
            return context.Locations.Single(x => x.LocationId == id);
        }

        /// <summary>
        /// Items in inventory get affected
        /// </summary>
        /// <param name="inventoryItem"></param>

        public void AddInventoryItem(InventoryItem inventoryItem)
        {
            context.InventoryItems.Add(inventoryItem);
        }

        public void UpdateInventoryItem(InventoryItem inventoryItem)
        {
            context.InventoryItems.Update(inventoryItem);
        }

/*        public InventoryItem GetInventoryItemById(int id)
        {
            return context.InventoryItems.Single(x => x.IIId == id);
        }*/

        public List<InventoryItem> GetAllInventoryItemsById(int id)
        {
            return context.InventoryItems.Where(x => x.IIId == id).ToList();
        }

        public InventoryItem GetInventoryItemByLocationId(int id)
        {
            return context.InventoryItems.Single(x => x.LocationId == id);
        }

        public List<InventoryItem> GetAllInventoryItemsByLocationId(int id)
        {
            return context.InventoryItems.Where(x => x.LocationId == id).ToList();
        }

        public void DeleteInventoryItem(InventoryItem inventoryItem)
        {
            context.InventoryItems.Remove(inventoryItem);
        }

        public InventoryItem GetItemByLocationIdProductId(int locationId, int productId)
        {
            return context.InventoryItems.Single(x=>x.LocationId == locationId
                && x.ProductId==productId);
        }

        public InventoryItem GetInventoryItemById(int id)
        {
            return context.InventoryItems.Single(x => x.IIId == id);
        }

        /// <summary>
        /// Cart item methods
        /// </summary>
        /// <param name="cart"></param>
        public void AddCartItem(CartItem cart)
        {
            context.CartItems.Add(cart);
        }

        public void UpdateCartItem(CartItem cartItem)
        {
            context.CartItems.Update(cartItem);
        }

        public CartItem GetCartItemById(int id)
        {
            return context.CartItems.Single(x => x.CIId == id);
        }

        public CartItem GetCartItemByCartId(int id)
        {
            return context.CartItems.Single(x => x.CartIId == id);
        }

        public List<CartItem> GetAllCartItemsByCartId(int id)
        {
            return context.CartItems.Where(x => x.CartIId == id).ToList();
        }

        public void DeleteCartItem(CartItem cart)
        {
            context.CartItems.Remove(cart);
        }

        /// <summary>
        /// Cart manipulation
        /// </summary>
        /// <param name="cart"></param>
        public void AddCart(Cart cart)
        {
            context.Carts.Add(cart);
        }

        public void UpdateCart(Cart cart)
        {
            context.Carts.Update(cart);
        }

        public Cart GetCartById(int id)
        {
            return context.Carts.Single(x => x.CartId == id);
        }

        public Cart GetCartByUserId(int id)
        {
            return context.Carts.Single(x => x.UserId == id);
        }

        public void DeleteCart(Cart cart)
        {
            context.Carts.Remove(cart);
        }
    }
}
