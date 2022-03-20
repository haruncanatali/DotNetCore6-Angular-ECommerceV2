using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Domain.Entities.Abstract;

namespace ETicaretAPI.Domain.Entities.Concrete
{
    public class Order:IEntity
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public DateTime UpdatedTime { get; set; }
        public DateTime CreatedTime { get; set; }

        public int CustomerId { get; set; }

        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }
    }
}
