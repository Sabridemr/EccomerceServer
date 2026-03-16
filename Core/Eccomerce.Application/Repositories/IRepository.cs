using System.Collections.Generic;
using Eccomerce.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace Eccomerce.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }

    }
} 