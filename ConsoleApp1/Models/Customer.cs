using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Customer : BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Cnic { get; set; }
        public int Age { get; set; }
        public List<Order> Orders { get; set; }
        public static int CustomerCount { get; private set; } = 0;

        public Customer(int id, string name, string address, int cnic, int age=-1)
        {
            Id = id;
            Name = name;
            Address = address;
            Cnic = cnic;
            Age = age;
            Orders = new List<Order>();
            CustomerCount++;
        }
        public override string ToString()
        {
            return "Customer Name: " + Name + "\nCustomer Address: " + Address + "\nCustomer CNIC: " + Cnic + "\nCustomer Age: " + Age + "\n";
        }

        public void DisplayOrders()
        {
            foreach (var order in Orders)
                Console.Write(order.ToString());
        }
    }
}
