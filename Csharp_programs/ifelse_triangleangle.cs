//14. Write a C# Sharp program to check whether a triangle is Equilateral, Isosceles or Scalene.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_triangleangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            Console.WriteLine("Angle of x: ");
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Angle of y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Angle of z: ");
            z = Convert.ToInt32(Console.ReadLine());
            if(x==y && x==z && y==z)
            {
                Console.WriteLine("triangle is Equilateral");
            }
            else if(x==y || x==z )
            {
                Console.WriteLine("This is an isosceles triangle. ");
            }
            else
            {
                Console.WriteLine("This is an Scalene triangle.");
            }

            Console.ReadKey();
        }
    }
}
