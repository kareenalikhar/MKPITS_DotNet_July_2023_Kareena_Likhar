//4. Write a C# Sharp program to read 10 numbers and find their average and sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_sumaverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            float avg=1;
            for(num=1;num<=10;num++)
            {
                Console.WriteLine(num);
                sum=sum+num;
                avg=sum/10;
            }
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = "+avg);
            Console.ReadKey();
        }
    }
}
