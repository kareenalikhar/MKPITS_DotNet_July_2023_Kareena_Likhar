//2. Write a C# Sharp program to check whether a given number is even or odd.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_evenodd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number: ");
            num=Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("number is even:");
            }
            else
            {
                Console.WriteLine("number is odd:");
            }
            Console.ReadKey();
        }
    }
}
