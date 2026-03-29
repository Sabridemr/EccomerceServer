using System.Net;
using System.Threading.Tasks;
using Eccomerce.Application.Repositories;
using Eccomerce.Application.ViewModels.Products;
using Eccomerce.Domain.Entities;
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

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _productReadRepository.GetByIdAsync(id,false));
        }

       [HttpGet]
       public async Task<IActionResult> Get()
        {
            return Ok(_productReadRepository.GetAll(false));
          
        }

        [HttpPost]
        public async Task<IActionResult> Post(Product model)
        {
            await _productWriteRepository.AddAsync(model);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Product product)
        {
            await _productWriteRepository.AddAsync(new()
            {
                Name = product.Name,
                Price = product.Price,
                Stock = product.Stock 
                
            });
            await _productWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_Product model)
        {
            Product product = await _productReadRepository.GetByIdAsync(model.Id);
            product.Stock = model.Stock;
            product.Price = model.Price;
            product.Name = model.Name;
            await _productWriteRepository.SaveAsync(); 

            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string id)
        {
            await _productWriteRepository.RemoveAsync(id);
            await _productWriteRepository.SaveAsync();
            return Ok();
        }

    }
}