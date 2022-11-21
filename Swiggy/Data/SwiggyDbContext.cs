using Microsoft.EntityFrameworkCore;
using Swiggy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swiggy.Data
{
    public class SwiggyDbContext:DbContext
    {
     
            public SwiggyDbContext(DbContextOptions options) : base(options)
            {

            }
            public DbSet<Products> products { get; set; }
            public DbSet<Orders> orders { get; set; }
            public DbSet<Customer>customer { get; set; }
       
        
        //public DbSet<CustomerOrders> customerOrders { get; set; }
        //public DbSet<ProductOrders> productOrders { get; set; }
        
    
    }
}
