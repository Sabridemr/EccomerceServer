using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eccomerce.Application.Repositories;
using Eccomerce.Domain.Entities;
using Eccomerce.Persistance.Contexts;

namespace Eccomerce.Persistance.Repositories
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(EccomerceDbContext context) : base(context)
        {
        }
        
    }
}