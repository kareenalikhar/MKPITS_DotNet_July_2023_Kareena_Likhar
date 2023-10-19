//2. Write a C# Sharp program to find the sum of the first 10 natural numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_1to10sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            for(num=1;num<=10;num++)
            {
                Console.WriteLine(num);
                sum=sum+num;
            } 
            Console.WriteLine("Sum = "+sum);
            Console.ReadKey();
        }
    }
}
