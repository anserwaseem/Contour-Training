using ConsoleApp1.Models;
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
            Console.WriteLine(customer1.ToString());

            Customer customer2 = new Customer(2,"Waseem", "Iqbal Town", 232422, 50);
            Console.WriteLine(customer2.ToString());

            Console.WriteLine(Customer.CustomerCount);


            Order order1 = new Order(1, customer1);

            OrderItem item1 = new OrderItem(order1, new Product("Perfume", "New Arrival", 5000, 5.0), 3);
            OrderItem item2 = new OrderItem(order1, new Product("Kurta", "30% Off", 7000, 30.0), 2);
            OrderItem item3 = new OrderItem(order1, new Product("Loafer", "Shoes", 4000, 0.0), 1);

            order1.AddOrderItem(item1);
            order1.AddOrderItem(item2);
            order1.AddOrderItem(item3);

            customer1.Orders.Add(order1);

            customer1.DisplayOrders();

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
