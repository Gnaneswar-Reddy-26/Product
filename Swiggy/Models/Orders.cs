using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Swiggy.Models
{
    public class Orders
    {
        [Key]
        public int orderId { get; set; }
        public string orderType { get; set; }
    }
}
