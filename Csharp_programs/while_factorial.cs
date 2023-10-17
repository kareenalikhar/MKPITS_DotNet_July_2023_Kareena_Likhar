//wap to accept a number print factorial of that no.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, fact=1;
            Console.WriteLine("Enter number: ");
            num=Convert.ToInt32(Console.ReadLine());
            while(num > 0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("Factorial: " + fact);
            Console.ReadKey();
        }
    }
}
