
using Eccomerce.Application.Abstraction;
using Eccomerce.Persistance.Concretes;
using Eccomerce.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Eccomerce.Persistance
{
    public static class ServiceRegistration
    {
        
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            services.AddDbContext<EccomerDbContext>(options => options.UseNpgsql("Host=localhost;Port=5432;Database=Eccomerce_Db;UserName=admin;Password=sifre123"));    
        }
        
    }

}