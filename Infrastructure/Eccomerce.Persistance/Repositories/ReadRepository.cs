using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eccomerce.Application.Repositories;
using Eccomerce.Domain.Entities.Common;
using Eccomerce.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;


namespace Eccomerce.Persistance.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {    
        private readonly EccomerceDbContext _context;

        public ReadRepository(EccomerceDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();
        public IQueryable<T> GetAll()
        => Table;

        public Task<T> GetSingleAsync(System.Linq.Expressions.Expression<Func<T, bool>> method)
        => Table.FirstOrDefaultAsync(method);

        public IQueryable<T> GetWhere(System.Linq.Expressions.Expression<Func<T, bool>> method)
        => Table.Where(method);

        public async Task<T> GetByIdAsync(string id)
        => await Table.FirstOrDefaultAsync(x=> x.Id == Guid.Parse(id));


    }
}