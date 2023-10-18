using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_average_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1, sum = 0;
            float avg;
            do
            {
                Console.WriteLine(num);
                sum = sum + num;
                num++;
            } while (num <= 10);
            Console.WriteLine("Sum : " + sum);
            avg = sum / 10.0f;
            Console.WriteLine("Average = " + avg);
            Console.ReadKey();

        }
    }
}
