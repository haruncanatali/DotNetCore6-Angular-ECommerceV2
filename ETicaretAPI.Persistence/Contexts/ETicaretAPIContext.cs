using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Entities.Abstract;
using ETicaretAPI.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace ETicaretAPI.Persistence.Contexts
{
    public class ETicaretAPIContext:DbContext
    {
        public ETicaretAPIContext(DbContextOptions<ETicaretAPIContext> options):base(options)
        { }

        public DbSet<Product> Tbl_Product { get; set; }
        public DbSet<Order> Tbl_Order { get; set; }
        public DbSet<Customer> Tbl_Customer { get; set; }


        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            var datas = ChangeTracker.Entries<IEntity>();

            foreach (var item in datas)
            {
                _=item.State switch
                {
                    EntityState.Added => item.Entity.CreatedTime = DateTime.UtcNow,
                    EntityState.Modified => item.Entity.UpdatedTime = DateTime.UtcNow
                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }
}
