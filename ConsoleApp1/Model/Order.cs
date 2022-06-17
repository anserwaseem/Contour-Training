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
            return $"Order Id: {Id}\nTotal: {Total}\nActive: {IsActive}\nDelivered: {IsDelivered}\nCancelled: {IsCancelled}\n\n{string.Join("", OrderItems)}";
        }

        public void AddOrderItem(OrderItem item)
        {
            int PreDiscountPrice = item.Product.Price * item.Quantity;
            Total += PreDiscountPrice - (PreDiscountPrice * item.Product.Discount / 100);
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
