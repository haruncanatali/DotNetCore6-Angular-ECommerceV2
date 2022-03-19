using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace ETicaretAPI.Application.Abstraction
{
    public interface IWriteRepository<TEntity> : IRepository<TEntity> where TEntity : class,IEntity
    {
        Task<bool> AddAsync(TEntity entity);
        Task<bool> AddRangeAsync(List<TEntity> entities);
        bool Remove(TEntity entity);
        Task<bool> RemoveAsync(string id);
        bool RemoveRange(List<TEntity> entities);
        bool Update(TEntity entity);
        Task<int> SaveAsync();
    }
}
