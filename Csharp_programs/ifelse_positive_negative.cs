//3. Write a C# Sharp program to check whether a given number is positive or negative.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_positive_negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter Number: ");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("Number is positive:");
            }
            else
            {
                Console.WriteLine("number is negative:");
            }
            Console.ReadKey();
        }
    }
}
