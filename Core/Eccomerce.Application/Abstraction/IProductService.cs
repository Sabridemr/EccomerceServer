using Eccomerce.Domain.Entities;

namespace Eccomerce.Application.Abstraction
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
    }
}