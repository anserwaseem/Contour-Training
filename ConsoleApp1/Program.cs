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
            Customer customer = new Customer();
            customer.Name = "Anser";
            customer.Address = "baker st.";
            customer.CNIC = 234343;

            //Object[] obj = { "ds", 15, true, 9.8 };

            //for (int i = 0; i < obj.Length; i++)
            //{
            //    Console.WriteLine(obj[i]);
            //}


            Console.WriteLine(customer.ToString());
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
