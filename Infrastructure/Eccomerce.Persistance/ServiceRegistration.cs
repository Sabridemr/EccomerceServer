using Eccomerce.Application.Repositories;
using Eccomerce.Persistance.Contexts;
using Eccomerce.Persistance.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Eccomerce.Persistance
{
    public static class ServiceRegistration
    {
        
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            
            services.AddDbContext<EccomerceDbContext>(options => options.UseNpgsql(Configurations.ConnectionString));
            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            
        }
        
    }

}