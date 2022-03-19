using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories.CustomerRepository;
using ETicaretAPI.Domain.Entities.Concrete;
using ETicaretAPI.Persistence.Contexts;

namespace ETicaretAPI.Persistence.Repositories.CustomerRepository
{
    public class CustomerReadRepository:ReadRepository<Customer>,ICustomerReadRepository
    {
        public CustomerReadRepository(ETicaretAPIContext context):base(context)
        {
            
        }
    }
}
