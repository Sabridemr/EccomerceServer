using Microsoft.EntityFrameworkCore.Design;
using Eccomerce.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace Eccomerce.Persistance
{
    public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<EccomerceDbContext>
    {
        public EccomerceDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<EccomerceDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configurations.ConnectionString);
            return new EccomerceDbContext(dbContextOptionsBuilder.Options);
        }
    }

}