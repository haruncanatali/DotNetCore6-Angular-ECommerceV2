using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Entities.Abstract;

namespace ETicaretAPI.Application.Abstraction
{
    public interface IReadRepository<TEntity>:IRepository<TEntity> where TEntity:class,IEntity
    {
        IQueryable<TEntity> GetAll(bool tracking = true);
        IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> filter,bool tracking = true);
        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> filter,bool tracking = true);
        Task<TEntity> GetByIdAsync(string id,bool tracking = true);
    }
}
