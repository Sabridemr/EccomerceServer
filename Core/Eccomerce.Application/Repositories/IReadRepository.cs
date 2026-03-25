using System.Linq.Expressions;
using Eccomerce.Domain.Entities.Common;

namespace Eccomerce.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method , bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method , bool tracking = true);
        Task<T> GetByIdAsync(string id,bool tracking = true);


    }
}
