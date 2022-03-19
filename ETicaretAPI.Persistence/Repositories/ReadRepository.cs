using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Abstraction;
using ETicaretAPI.Domain.Entities.Abstract;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Persistence.Repositories
{
    public class ReadRepository<TEntity>:IReadRepository<TEntity> where TEntity:class,IEntity
    {
        private readonly ETicaretAPIContext context;

        public ReadRepository(ETicaretAPIContext context)
        {
            this.context = context;
        }

        public DbSet<TEntity> Table => context.Set<TEntity>();
        public IQueryable<TEntity> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }

        public IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> filter, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if ( !tracking )
                query = query.AsNoTracking();
            return query.Where(filter);
        }

        public async Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> filter, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(filter);

        }

        public async Task<TEntity> GetByIdAsync(string id, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(c => c.Id == Guid.Parse(id));

        }
    }
}
