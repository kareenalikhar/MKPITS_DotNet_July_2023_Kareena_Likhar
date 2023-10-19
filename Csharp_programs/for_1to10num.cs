//1. Write a program in C# Sharp to display the first 10 natural numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_1to10num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            for(num=1;num<=10;num++)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
