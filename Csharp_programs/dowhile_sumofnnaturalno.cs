//3. Write a C# Sharp program that displays the sum of n natural numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_sumofnnaturalno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, counter = 1, sum = 0;
            Console.WriteLine("Enter num: ");
            num = Convert.ToInt32(Console.ReadLine());
            do
            {
                sum = sum + counter;
                Console.Write("{0} ", counter);
                counter++;
            } while (num >= counter);
            Console.WriteLine("\nSum=" + sum);
            Console.ReadKey();
        }
    }
}
