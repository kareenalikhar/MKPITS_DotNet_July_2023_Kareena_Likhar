//15. Write a C# Sharp program to check whether a triangle can be formed by the given angles value.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_trianglevalid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a1, a2, a3;
            Console.WriteLine("Enter angle1: ");
            a1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter angle2: ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter angle3: ");
            a3 = Convert.ToInt32(Console.ReadLine());
            if (a1 + a2 + a3 == 180) 
            {
                Console.WriteLine("The triangle is valid.");
            }
            else
            {
                Console.WriteLine("The triangle is not valid.");
            }
            Console.ReadKey();
        }
    }
}
