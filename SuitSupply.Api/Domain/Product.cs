using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuitSupply.Api.Domain
{
    public class Product
    {
        public int Id { get; protected set; }

        public string Name { get; protected set; }

        public decimal Price { get; protected set; }

        public Product(int id, string name, decimal price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
    }
}
