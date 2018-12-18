using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuitSupply.Api.Controllers;

namespace SuitSupply.Api.Tests
{
    [TestClass]
    public class ProductsControllerTests
    {
        [TestMethod]
        public void Get_ShouldReturnAllProducts()
        {
            var dummyProducts = this.GetProducts();
            var productsController = new ProductsController();
        }

        public IList<Product> GetProducts()
        {
            var dummyProducts = new List<Product>();
            dummyProducts.Add(new Product(1, "Dummy 1", 3.75M));
            dummyProducts.Add(new Product(1, "Dummy 2", 4.75M));

            return dummyProducts;
        }
    }
}
