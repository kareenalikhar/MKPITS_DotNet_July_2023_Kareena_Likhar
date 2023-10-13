//1. Write a C# Sharp program to accept two integers and check whether they are equal or not.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_equal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Enter num1: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2) 
            {
                Console.WriteLine("num1 is equal to num2");
            }
            else
            {
                Console.WriteLine("num1 is not equal to num2");
            }
            Console.ReadKey();
        }
    }
}
