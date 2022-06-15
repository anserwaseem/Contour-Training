using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Product : BaseModel
    {
        public OrderItem OrderItem { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public double Discount { get; set; }
    
        public Product(string name, string description, int price, double discount)
        {
            Name = name;
            Description = description;
            Price = price;
            Discount = discount;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nDescription {Description}\nPrice {Price}\nDiscount: {Discount}\n";
        }
    }
}
