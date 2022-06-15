using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class Order : BaseModel
    {
        public Customer Customer { get; set; }
        public DateTime OrderedOn { get; set; }
        public int Total { get; set; } = 0;
        public bool IsActive { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsCancelled { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public Order()
        {
            OrderedOn = DateTime.Now;
        }
        public Order(int id, Customer customer)
        {
            Id = id;
            Customer = customer;
            OrderedOn = DateTime.Now;
            IsActive = true;
            IsDelivered = false;
            IsCancelled = false;
            OrderItems = new List<OrderItem>();
        }
        public override string ToString()
        {
            return $"Ïd: {Id}\nTotal: {Total}\nActive: {IsActive}\nDelivered: {IsDelivered}\nCancelled: {IsCancelled}\n";//{OrderItems.ForEach(item => item.ToString())}
        }

        public void AddOrderItem(OrderItem item)
        {
            Total += item.Product.Price * item.Quantity;
            try
            {
                OrderItems.Add(item);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
