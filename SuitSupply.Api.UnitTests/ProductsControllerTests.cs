using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuitSupply.Api.Controllers;
using SuitSupply.Api.Domain;
using System.Collections.Generic;

namespace SuitSupply.Api.UnitTests
{
    [TestClass]
    public class ProductsControllerTests
    {
        [TestMethod]
        public void Get_ShouldReturnAllProducts()
        {
            // Arrange
            var testProducts = this.GetProducts();
            var controller = new ProductsController(testProducts);

            // Act
            var results = controller.Get();

            // Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(testProducts.Count, results.Count);
            Assert.AreEqual(testProducts[0].Name, results[0].Name);
        }

        private IList<Product> GetProducts()
        {
            var dummyProducts = new List<Product>();
            dummyProducts.Add(new Product(1, "Dummy 1", 3.75M));
            dummyProducts.Add(new Product(1, "Dummy 2", 4.75M));

            return dummyProducts;
        }
    }
}
