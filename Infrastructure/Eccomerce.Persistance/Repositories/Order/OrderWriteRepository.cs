using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eccomerce.Application.Repositories;
using Eccomerce.Domain.Entities;
using Eccomerce.Persistance.Contexts;

namespace Eccomerce.Persistance.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(EccomerceDbContext context) : base(context)
        {
        }
        
    }
}