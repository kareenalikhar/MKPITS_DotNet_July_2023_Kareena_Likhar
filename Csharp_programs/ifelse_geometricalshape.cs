//24. Write a C# Sharp program that calculates the area of geometrical shapes using a menu-driven approach.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_geometricalshape
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Enter 1 for Circle:");
            Console.WriteLine("Enter 2 for Rectangle:");
            Console.WriteLine("Enter 3 for triangle:");
            choice=Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                int radius;
                float area;
                Console.Write("Enter radius: ");
                radius = Convert.ToInt32(Console.ReadLine());
                area = 3.14f * radius * radius;
                Console.WriteLine("Area of Circle: " + area);
            }
            else if(choice == 2)
            {
                int l, b;
                float area1;
                Console.Write("Enter length: ");
                l= Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter breadth: ");
                b= Convert.ToInt32(Console.ReadLine());
                area1 = l * b;
                Console.WriteLine("Area of rectangle: " + area1);
            }
            else if (choice == 3)
            {
                int l, h;
                float area2;
                Console.Write("Enter length: ");
                l = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter breadth: ");
                h = Convert.ToInt32(Console.ReadLine());
                area2 = 0.5f * l * h;
                Console.WriteLine("Area of rectangle: " + area2);
            }
            Console.ReadKey();
        }
    }
}
