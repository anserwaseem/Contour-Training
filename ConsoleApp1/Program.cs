using ConsoleApp1.Models;
using ConsoleApp1.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(1,"Anser", "Johar Town", 234343, 22);
            //Console.WriteLine(customer1.ToString());
            Customer customer2 = new Customer(2, "Waseem", "Iqbal Town", 232422, 50);
            //Console.WriteLine(customer2.ToString());

            CustomerRepository customerRepository = new CustomerRepository();
            customerRepository.Add(customer1);
            customerRepository.Add(customer2);
            customerRepository.Get().ForEach(entity => Console.WriteLine(entity));

            Console.WriteLine("After Deleting Customer object:\n");
            customerRepository.Delete(customer2);
            customerRepository.Get().ForEach(entity => Console.WriteLine(entity));

            //Console.WriteLine($"Total Customers: {Customer.CustomerCount}\n");


            //Order order1 = new Order(1, customer1);

            //OrderItem item1 = new OrderItem(1, order1, new Product(1, "Panadol", "Tablet", 50, Product.Categories.Health), 10);
            //OrderItem item2 = new OrderItem(2, order1, new Product(2, "Kurta", "30% Off", 7000, Product.Categories.Fashion), 2);
            //OrderItem item3 = new OrderItem(3, order1, new Product(3, "Loafer", "Shoes", 4000, Product.Categories.Fashion), 1);
            //order1.AddOrderItem(item1);
            //order1.AddOrderItem(item2);
            //order1.AddOrderItem(item3);

            //OrderRepository orderRepository = new OrderRepository();
            //orderRepository.Add(order1);



            //customer1.Orders.Add(order1);

            ////customer1.DisplayOrders();


            //Order order2 = new Order(2, customer1);

            //OrderItem item21 = new OrderItem(4, order2, new Product(4, "Shirt", "", 2000, Product.Categories.Fashion), 11);
            //OrderItem item22 = new OrderItem(5, order2, new Product(5, "Mouse", "Elec", 3000, Product.Categories.Electronics), 3);
            //OrderItem item23 = new OrderItem(6, order2, new Product(6, "Bruffin", "Syrup", 1000, Product.Categories.Health), 4);

            //order2.AddOrderItem(item21);
            //order2.AddOrderItem(item22);
            //order2.AddOrderItem(item23);

            //customer1.Orders.Add(order2);

            //customer1.DisplayOrders();

            //Object[] items = { "ds", 15, true, 9.8 };
            //foreach (var item in items)
            //    Console.WriteLine(item);

            //List<List<string>> list = new List<List<string>>();
            //list.Add(new List<string>());
            //list.Add(new List<string>());
            //list.Add(new List<string>());

            //list[0].Add("<Name>");
            //list[0].Add("<Age>");
            //list[1].Add("Anser");
            //list[1].Add("22");
            //list[2].Add("Faisal");
            //list[2].Add("23");

            //list.ForEach(row =>
            //{
            //    row.ForEach(x => Console.Write(x + '\t'));
            //    Console.WriteLine('\n');
            //});

            //int num1, num2, num3;
            //try
            //{
            //    num1=Convert.ToInt32(Console.ReadLine());
            //    num2 = Convert.ToInt32(Console.ReadLine());
            //    num3 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(GetMax(num1,num2,num3));
            //}
            //catch
            //{
            //    Console.WriteLine("Wrong input");
            //}

            Console.ReadKey();
        }
        //static double CalculateCube(int number)
        //{
        //    return Math.Pow(number, 3);
        //}
        //static int GetMax(int num1, int num2, int num3)
        //{
        //    return num1 > num2 && num1 > num3 ? num1 : num2 > num1 && num2 > num3 ? num2 : num3;
        //}
    } 
}
