//3. Write a program in C# Sharp to create a function for the sum of two numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_addition
{
    internal class Program
    {
        static int addition(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        static void Main(string[] args)
        {
            int num1, num2, result;
            Console.Write("Enter Num1: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            result=addition(num1, num2);
            Console.WriteLine("The sum of two numbers is : " + result);

            Console.ReadKey();

        }
    }
}
