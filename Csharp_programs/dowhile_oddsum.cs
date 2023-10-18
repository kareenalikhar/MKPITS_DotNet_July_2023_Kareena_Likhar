//8. Write a C# Sharp program to display the n terms of odd natural numbers and their sums.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_odd_sum
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
                if (counter % 2 != 0)
                {
                    Console.Write("{0} ", counter);
                    sum = sum + counter;
                }
                counter++;
            } while (counter <= num);
            Console.WriteLine("\nSum is " + sum);

            Console.ReadKey();
        }
    }
}
