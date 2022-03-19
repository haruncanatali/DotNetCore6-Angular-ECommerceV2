using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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


    }
}
