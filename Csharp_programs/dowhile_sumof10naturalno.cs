//2. Write a C# Sharp program to find the sum of the first 10 natural numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_naturalno1to10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1, sum = 0;
            do
            {
                sum = sum + num;
                Console.Write(num);
                num++;
            } while (num <= 10);
            Console.WriteLine("\nSum= " + sum);
            Console.ReadKey();
        }
    }
}
