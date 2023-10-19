//8. Write a C# Sharp program to display the n terms of odd natural numbers and their sums.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_oddsum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cnt, sum=1;
            Console.Write("Enter Number: ");
            num=Convert.ToInt32(Console.ReadLine());
            for(cnt=1; cnt<=num; cnt++)
            {
                if(num%cnt!=0)
                {
                    Console.WriteLine(cnt);
                    sum = sum + cnt;
                }

            }
            Console.WriteLine("Sum = " + sum);
            Console.ReadKey();
        }
    }
}
