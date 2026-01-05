using Eccomerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eccomerce.Persistance.Contexts
{
    public class EccomerDbContext:DbContext
    {
        public EccomerDbContext(DbContextOptions<EccomerDbContext> options):base(options)
        {}

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}