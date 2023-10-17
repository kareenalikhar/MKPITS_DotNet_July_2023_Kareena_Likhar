//Write a program in C# Sharp which is a menu-driven program to perform simple calculations.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int num1, num2, result;
            Console.WriteLine("Enter 1 for Addition\n2 for Substraction\n3 for Multiplication\n4 for Division: ");
            choice =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num1: ");
            num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("Addition : " + result);
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine("Substraction : " + result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("Multiplication : " + result);
                    break;
                case 4:
                    result = num1 / num2;
                    Console.WriteLine("Division : " + result);
                    break;
            }
            Console.ReadKey();
        }
    }
}
