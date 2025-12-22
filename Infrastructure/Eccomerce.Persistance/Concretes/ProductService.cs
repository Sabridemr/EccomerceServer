using Eccomerce.Application.Abstraction;
using Eccomerce.Domain.Entities;

namespace Eccomerce.Persistance.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetAllProducts() => new()
        {
            new() { Id = Guid.NewGuid(), Name = "Product 1", Price = 10.99m, Stock = 100 },
            new() { Id = Guid.NewGuid(), Name = "Product 2", Price = 15.49m, Stock = 50 },
            new() { Id = Guid.NewGuid(), Name = "Product 3", Price = 7.99m, Stock = 200  },
            new() { Id = Guid.NewGuid(), Name = "Product 4", Price = 20.00m, Stock = 75  },
            new() { Id = Guid.NewGuid(), Name = "Product 5", Price = 5.49m, Stock = 150  }
        };
        
    }
}