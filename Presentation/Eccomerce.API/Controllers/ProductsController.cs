using Eccomerce.Application.Abstraction;
using Microsoft.AspNetCore.Mvc;

namespace Eccomerce.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet]
        public IActionResult GetProductById(int id)
        {
            var product = _productService.GetProductById(id);
            return Ok(product);
        }
        
    }
}