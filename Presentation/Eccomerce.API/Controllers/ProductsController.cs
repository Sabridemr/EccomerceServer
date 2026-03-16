using System.Threading.Tasks;
using Eccomerce.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Eccomerce.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
       
       readonly private IProductWriteRepository _productWriteRepository;
       readonly private IProductReadRepository _productReadRepository;
       public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
       {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
       }
       
       [HttpGet]
       public async Task Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                    new() { Id = Guid.NewGuid(),Name = "Product 1", Price = 100, Stock = 10 },
                    new() { Id = Guid.NewGuid(),Name = "Product 2", Price = 200, Stock = 20 },
                    new() { Id = Guid.NewGuid(),Name = "Product 3", Price = 300, Stock = 30 },
                    new() { Id = Guid.NewGuid(),Name = "Product 4", Price = 400, Stock = 40 },
                    new() { Id = Guid.NewGuid(),Name = "Product 5", Price = 500, Stock = 50 }   
            });
            await _productWriteRepository.SaveAsync();
        }


        
        
    }
}