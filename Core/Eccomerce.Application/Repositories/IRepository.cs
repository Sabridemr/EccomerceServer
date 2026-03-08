using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Eccomerce.Application.Repositories
{
    public interface IRepository<T> where T : class
    {
        DbSet<T> Table { get; }

    }
} 