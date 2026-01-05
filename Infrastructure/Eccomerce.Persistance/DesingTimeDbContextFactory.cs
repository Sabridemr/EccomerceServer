using Microsoft.EntityFrameworkCore.Design;
using Eccomerce.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Eccomerce.Persistance
{
    public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<EccomerDbContext>
    {
        public EccomerDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<EccomerDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configurations.ConnectionString);
            return new EccomerDbContext(dbContextOptionsBuilder.Options);
        }
    }

}