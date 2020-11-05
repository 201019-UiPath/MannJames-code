using Xunit;
using StoreDB.Models;
using StoreDB;
using StoreDB.Repos;
using System.Linq;

namespace StoreTest
{
    public class ProductTest
    {
        [Fact]
        public void AddProdShouldAdd()
        {
            using var testContext = new StoreContext();
            IProductRepo repo = new DBRepo(testContext);
            Product testProduct = new Product();
            testProduct.Price = 5.00M;
            testProduct.ProductName = "testName";
            repo.AddProduct(testProduct);
            Assert.NotNull(testContext.Products.Single(p => p.ProductName
            == testProduct.ProductName));
            //repo.DeleteProduct(testProduct);
        }
    }
}
