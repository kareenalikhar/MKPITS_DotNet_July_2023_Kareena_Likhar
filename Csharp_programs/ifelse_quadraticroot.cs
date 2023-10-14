//11. Write a C# Sharp program to calculate the root of a quadratic equation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_quadraticroot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,result;
            Console.WriteLine("value of a : ");
            a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value of b : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("value of c : ");
            c = Convert.ToInt32(Console.ReadLine());
            result=( b * b )- 4 * a *c;

            if (result!=0)
            {
                Console.WriteLine("Root are imaginary;"+result);
            }
            else 
            {
                Console.WriteLine("number is real: " +result);
            }
            
            Console.ReadKey();
        }
    }
}
