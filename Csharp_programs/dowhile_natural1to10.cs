//1. Write a program in C# Sharp to display the first 10 natural numbers.

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
            int num = 1;
            do
            {
                Console.Write("{0} ", num);
                num++;
            } while (num <= 10);
            Console.ReadKey();
        }
    }
}
