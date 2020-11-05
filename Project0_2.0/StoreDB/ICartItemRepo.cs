using StoreDB.Models;
using System.Collections.Generic;

namespace StoreDB.Repos
{
    public interface ICartItemRepo
    {
        public void AddCartItem(CartItem cart);
        public void UpdateCartItem(CartItem cartItem);
        public CartItem GetCartItemById(int id);
        public CartItem GetCartItemByCartId(int id);
        public List<CartItem> GetAllCartItemsByCartId(int id);
        public void DeleteCartItem(CartItem cart);
    }
}
