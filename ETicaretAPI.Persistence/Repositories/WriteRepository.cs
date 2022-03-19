using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Abstraction;
using ETicaretAPI.Domain.Entities.Abstract;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ETicaretAPI.Persistence.Repositories
{
    public class WriteRepository<TEntity> : IWriteRepository<TEntity> where TEntity : class, IEntity
    {
        private readonly ETicaretAPIContext? context;

        public WriteRepository(ETicaretAPIContext context)
        {
            this.context = context;
        }

        public DbSet<TEntity> Table => context.Set<TEntity>();

        public async Task<bool> AddAsync(TEntity entity)
        {
            EntityEntry<TEntity> eState = await Table.AddAsync(entity);
            return eState.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<TEntity> entities)
        {
            await Table.AddRangeAsync(entities);
            return true;
        }

        public bool Remove(TEntity entity)
        {
            EntityEntry<TEntity> eState = Table.Remove(entity);
            return eState.State == EntityState.Deleted;
        }

        public async Task<bool> RemoveAsync(string id)
        {
            var entity = await Table.FirstOrDefaultAsync(c => c.Id == Guid.Parse(id));
            return Remove(entity);
        }

        public bool RemoveRange(List<TEntity> entities)
        {
            Table.RemoveRange(entities);
            return true;
        }

        public bool Update(TEntity entity)
        {
            EntityEntry<TEntity> eState = Table.Update(entity);
            return eState.State == EntityState.Modified;
        }

        public async Task<int> SaveAsync() => await context.SaveChangesAsync();
    }
}
