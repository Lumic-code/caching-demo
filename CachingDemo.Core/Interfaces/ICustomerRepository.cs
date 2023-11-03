using CachingDemo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CachingDemo.Core.Interfaces
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
    }
}
