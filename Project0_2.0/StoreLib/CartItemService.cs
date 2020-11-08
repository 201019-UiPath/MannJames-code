using StoreDB.Repos;
using System.Collections.Generic;
using StoreDB.Models;

namespace StoreLib
{
    public class CartItemService
    {
        private ICartItemRepo repo;
        public CartItemService(ICartItemRepo repo)
        {
            this.repo = repo;
        }
        public void AddCartItem(CartItem cart)
        {
            repo.AddCartItem(cart);
        }
        public void UpdateCartItem(CartItem cartItem)
        {
            repo.UpdateCartItem(cartItem);
        }
        public CartItem GetCartItemById(int id)
        {
            CartItem result = repo.GetCartItemById(id);
            return result;
        }
        public CartItem GetCartItemByCartId(int id)
        {
            CartItem result = repo.GetCartItemByCartId(id);
            return result;
        }
        public List<CartItem> GetAllCartItemsByCartId(int id)
        {
            List<CartItem> resultList = repo.GetAllCartItemsByCartId(id);
            return resultList;
        }
        public void DeleteCartItem(CartItem cart)
        {
            repo.DeleteCartItem(cart);
        }
    }
}
