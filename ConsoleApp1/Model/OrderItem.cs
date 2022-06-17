using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class OrderItem : BaseModel
    {
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime AddedAt { get; set; }

        public OrderItem(int id, Order order, Product product, int quantity)
        {
            Id = id;
            Order = order;
            Product = product;
            Quantity = quantity;
            AddedAt = DateTime.Now;
        }

        public override string ToString()
        {
            return $"OrderItem Id: {Id}\nQuantity: {Quantity}\nAdded At: {AddedAt}\n\n{Product}\n";
        }
    }
}
