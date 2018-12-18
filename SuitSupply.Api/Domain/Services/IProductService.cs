using System.Collections.Generic;

namespace SuitSupply.Api.Domain.Services
{
    public interface IProductService
    {
        IList<Product> GetProducts();
    }
}
