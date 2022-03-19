using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Application.Abstraction
{
    public interface IRepository<TEntity> where TEntity : class,IEntity
    {
        DbSet<TEntity> Table { get; }
    }
}
