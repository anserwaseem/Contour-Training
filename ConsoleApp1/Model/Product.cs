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
        public int Discount { get; private set; }
        public enum Categories
        {
            Health,
            Fashion,
            Electronics,
        }

        public Product(int id, string name, string description, int price, Categories category)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;

            switch (category)
            {
                case Categories.Health:
                    Discount = 7;
                    break;
                case Categories.Fashion:
                    Discount = 10;
                    break;
                case Categories.Electronics:
                    Discount = 2;
                    break;
                default:
                    Discount = 0;
                    break;
            }
        }

        public override string ToString()
        {
            return $"Product Id: {Id}\nName: {Name}\nDescription {Description}\nPrice {Price}\nDiscount: {Discount}\n";
        }
    }
}
