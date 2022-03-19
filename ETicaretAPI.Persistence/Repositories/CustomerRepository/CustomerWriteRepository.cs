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
    public class CustomerWriteRepository:WriteRepository<Customer>,ICustomerWriteRepository
    {
        public CustomerWriteRepository(ETicaretAPIContext context):base(context)
        {
            
        }
    }
}
