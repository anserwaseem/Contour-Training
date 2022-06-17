using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class ProductInventory : BaseModel
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}
