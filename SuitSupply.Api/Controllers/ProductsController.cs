using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuitSupply.Api.Domain;
using SuitSupply.Api.Domain.Services;

namespace SuitSupply.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Products")]
    public class ProductsController : Controller
    {
        private readonly IProductService _service;

        public ProductsController(IProductService service)
        {
            this._service = service;
        }

        [HttpGet]
        public IList<Product> Get()
        {
            return this._service.GetProducts();
        }
    }
}