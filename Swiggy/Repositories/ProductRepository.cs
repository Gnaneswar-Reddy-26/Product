using Microsoft.EntityFrameworkCore;
using Swiggy.Data;
using Swiggy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swiggy.Repositories
{
    public class ProductRepository : IproductRepository
    {
        protected SwiggyDbContext _context;
        public ProductRepository(SwiggyDbContext context)
        {
            _context = context;
        }
        public IEnumerable<OrderInformation> GetProducts2()
        {
            var productList = (from p in _context.products
                               from o in _context.orders
                               from c in _context.customer
                               select new OrderInformation()
                               {
                                   productId = p.productId,
                                   productName = p.productName,
                                   productPrice = p.productPrice,
                                   productType = p.productType,
                                   orderId = o.orderId,
                                   orderType = o.orderType,
                                   customerId = c.customerId,
                                   customerName = c.customerName,
                                   customerAddress = c.customerAddress
                               }).ToList();
            return productList;
        }
    }
}
