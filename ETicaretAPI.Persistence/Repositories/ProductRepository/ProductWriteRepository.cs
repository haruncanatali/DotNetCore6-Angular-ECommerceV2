using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories.ProductRepository;
using ETicaretAPI.Domain.Entities.Concrete;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.ProductRepository
{
    public class ProductWriteRepository:WriteRepository<Product>,IProductWriteRepository
    {
        public ProductWriteRepository(ETicaretAPIContext context):base(context)
        {
            
        }
    }
}
