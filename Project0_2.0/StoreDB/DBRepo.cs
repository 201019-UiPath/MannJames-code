using StoreDB.Models;
using StoreDB.Repos;
using System.Collections.Generic;
using System.Linq;

namespace StoreDB
{
    public class DBRepo : IProductRepo
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
    }
}
