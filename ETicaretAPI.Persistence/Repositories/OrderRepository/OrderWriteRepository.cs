using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories.OrderRepository;
using ETicaretAPI.Domain.Entities.Concrete;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.OrderRepository
{
    public class OrderWriteRepository:WriteRepository<Order>,IOrderWriteRepository
    {
        public OrderWriteRepository(ETicaretAPIContext context):base(context)
        {
            
        }
    }
}
