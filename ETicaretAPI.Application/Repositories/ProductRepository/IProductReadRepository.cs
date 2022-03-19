using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Abstraction;
using ETicaretAPI.Domain.Entities.Concrete;

namespace ETicaretAPI.Application.Repositories.ProductRepository
{
    public interface IProductReadRepository:IReadRepository<Product>
    {
    }
}
