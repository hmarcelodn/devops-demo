using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuitSupply.Api.Domain;

namespace SuitSupply.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        private IList<Product> _products;

        public ProductsController()
        {
            var dummyProducts = new List<Product>();
            dummyProducts.Add(new Product(1, "Dummy 1", 3.75M));
            dummyProducts.Add(new Product(1, "Dummy 2", 4.75M));
        }

        public ProductsController(IList<Product> products)
        {
            this._products = products;
        }

        public IList<Product> Get()
        {
            return this._products;
        }
    }
}