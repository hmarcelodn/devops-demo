using SuitSupply.Api.Domain;
using SuitSupply.Api.Domain.Services;
using System.Collections.Generic;

namespace SuitSupply.Api.Services
{
    public class ProductService : IProductService
    {
        public IList<Product> GetProducts()
        {
            var dummyProducts = new List<Product>();
            dummyProducts.Add(new Product(1, "Dummy 1", 3.75M));
            dummyProducts.Add(new Product(1, "Dummy 2", 4.75M));

            return dummyProducts;
        }
    }
}
