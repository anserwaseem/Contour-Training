using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Order
    {
        public Customer Customer { get; set; }
        public DateTime OrderedOn { get; set; } 
        public int Total { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsCancelled { get; set; }

        // many order_items
    }
}
