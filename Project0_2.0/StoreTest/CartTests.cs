using System.Collections.Generic;
using System.Linq;
using StoreDB;
using StoreDB.Models;
using StoreDB.Repos;
using Xunit;

namespace StoreTest
{
    public class CartTests
    {
        #region Cart
        [Fact]
        public void AddCart()
        {
            using var context = new StoreContext();
            ICartRepo repo = new DBRepo(context);

            Cart testCart = new Cart();
            testCart.UserId = 1;

            repo.AddCart(testCart);
            Assert.NotNull(context.Carts.Single(q => q.CartId == testCart.CartId));
            repo.DeleteCart(testCart);
        }
        [Fact]
        public void UpdateCart()
        {
            using var context = new StoreContext();
            ICartRepo repo = new DBRepo(context);

            Cart testCart = new Cart();
            testCart.UserId = 1;
            repo.AddCart(testCart);

            testCart.UserId = 2;
            repo.UpdateCart(testCart);
            Assert.Equal(2, testCart.UserId);

            repo.DeleteCart(testCart);
        }
        [Fact]
        public void GetCartById()
        {
            using var context = new StoreContext();
            ICartRepo repo = new DBRepo(context);

            Cart testCart = new Cart();
            testCart.UserId = 1;
            repo.AddCart(testCart);

            Assert.NotNull(repo.GetCartById(testCart.CartId));

            repo.DeleteCart(testCart);
        }
        [Fact]
        public void GetCartByUserId()
        {
            using var context = new StoreContext();
            ICartRepo repo = new DBRepo(context);

            Cart testCart = new Cart();
            testCart.UserId = 1;
            repo.AddCart(testCart);

            Assert.NotNull(repo.GetCartByUserId(testCart.UserId));

            repo.DeleteCart(testCart);
        }
        #endregion

        #region CartItems
        [Fact]
        public void AddCartItem()
        {
            using var context = new StoreContext();
            ICartRepo repo = new DBRepo(context);
            ICartItemRepo cirepo = new DBRepo(context);

            Cart testCart = new Cart();
            testCart.UserId = 1;

            repo.AddCart(testCart);

            CartItem testCartItem = new CartItem();
            testCartItem.CartIId = 1;
            testCartItem.ProductId = 1;
            testCartItem.Quantity = 10;
            cirepo.AddCartItem(testCartItem);

            Assert.NotNull(context.CartItems.Single(q => q.CIId == testCartItem.CIId));
            cirepo.DeleteCartItem(testCartItem);
            cirepo.DeleteCartItem(testCartItem);
            repo.DeleteCart(testCart);
        }
        [Fact]
        public void UpdateCartItem()
        {
            using var context = new StoreContext();
            ICartRepo repo = new DBRepo(context);
            ICartItemRepo cirepo = new DBRepo(context);

            Cart testCart = new Cart();
            testCart.UserId = 1;

            repo.AddCart(testCart);

            CartItem testCartItem = new CartItem();
            testCartItem.CartIId = 1;
            testCartItem.ProductId = 1;
            testCartItem.Quantity = 10;
            cirepo.AddCartItem(testCartItem);

            testCartItem.Quantity = 2;
            cirepo.UpdateCartItem(testCartItem);
            Assert.Equal(2, testCartItem.Quantity);

            cirepo.DeleteCartItem(testCartItem);
            repo.DeleteCart(testCart);
        }
        [Fact]
        public void GetCartItemById()
        {
            using var context = new StoreContext();
            ICartRepo repo = new DBRepo(context);
            ICartItemRepo cirepo = new DBRepo(context);

            Cart testCart = new Cart();
            testCart.UserId = 1;

            repo.AddCart(testCart);

            CartItem testCartItem = new CartItem();
            testCartItem.CartIId = 1;
            testCartItem.ProductId = 1;
            testCartItem.Quantity = 10;
            cirepo.AddCartItem(testCartItem);

            Assert.NotNull(cirepo.GetCartItemById(testCartItem.CIId));

            cirepo.DeleteCartItem(testCartItem);
            repo.DeleteCart(testCart);
        }
        [Fact]
        public void GetCartItemByCartId()
        {
            using var context = new StoreContext();
            ICartRepo repo = new DBRepo(context);
            ICartItemRepo cirepo = new DBRepo(context);

            Cart testCart = new Cart();
            testCart.UserId = 1;

            repo.AddCart(testCart);

            CartItem testCartItem = new CartItem();
            testCartItem.CartIId = 1;
            testCartItem.ProductId = 1;
            testCartItem.Quantity = 10;
            cirepo.AddCartItem(testCartItem);

            Assert.NotNull(cirepo.GetAllCartItemsByCartId(testCartItem.CartIId));

            cirepo.DeleteCartItem(testCartItem);
            repo.DeleteCart(testCart);
        }
        [Fact]
        public void GetAllCartItemsByCartId()
        {
            using var context = new StoreContext();
            ICartRepo repo = new DBRepo(context);
            ICartItemRepo cirepo = new DBRepo(context);

            Cart testCart = new Cart();
            testCart.UserId = 1;

            repo.AddCart(testCart);

            CartItem testCartItem = new CartItem();
            testCartItem.CartIId = 1;
            testCartItem.ProductId = 1;
            testCartItem.Quantity = 10;
            cirepo.AddCartItem(testCartItem);

            CartItem testCartItem2 = new CartItem();
            testCartItem2.CartIId = 1;
            testCartItem2.ProductId = 2;
            testCartItem2.Quantity = 15;
            cirepo.AddCartItem(testCartItem2);

            List<CartItem> items = cirepo.GetAllCartItemsByCartId(testCartItem.CartIId);
            Assert.NotNull(items);

            cirepo.DeleteCartItem(testCartItem);
            cirepo.DeleteCartItem(testCartItem2);
            repo.DeleteCart(testCart);
        }
        #endregion
    }
}