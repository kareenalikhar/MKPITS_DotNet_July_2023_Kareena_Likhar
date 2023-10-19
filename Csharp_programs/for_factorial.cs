//2 - wap to accept a number and print factorial

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, fact = 1;
            Console.WriteLine("Enter number: ");
            num=Convert.ToInt32(Console.ReadLine());
            for(int cnt=1;cnt<=num;cnt++)
            {
                fact=fact*cnt;
            }
            Console.WriteLine("fact: " + fact);
            Console.ReadKey();
        }
        
    }
}
