using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Swiggy.Models;

namespace Swiggy.Repositories
{
    interface IproductRepository
    {
        IEnumerable<OrderInformation> GetProducts2();
    }
}
