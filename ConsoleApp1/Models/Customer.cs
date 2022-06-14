using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int CNIC { get; set; }
        public Order Order { get; set; }
    }
}
