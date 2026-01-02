
using Eccomerce.Application.Abstraction;
using Eccomerce.Persistance.Concretes;
using Microsoft.Extensions.DependencyInjection;

namespace Eccomerce.Persistance
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
           
        }
        
    }

}