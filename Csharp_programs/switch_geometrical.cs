//Write a C# Sharp program that calculates the area of geometrical shapes using a menu-driven approach.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_geometrical
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Enter 1 for circle:\n 2 for triangle:\n 3 for rectangle: ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    int r;
                    float area;
                    Console.WriteLine("Enter radius: ");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14f * r * r;
                    Console.WriteLine("area of Circle: " + area);
                    break;
                case 2:
                    int l, b;
                    float area1;
                    Console.WriteLine("Enter length: ");
                    l= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Breadth: ");
                    b= Convert.ToInt32(Console.ReadLine());
                    area1 = 0.5f * l * b;
                    Console.WriteLine("Area of triangle: " + area1);
                break;
                    case 3:
                    int l1, b1;
                    float area2;
                    Console.WriteLine("Enter length: ");
                    l1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Breadth: ");
                    b1 = Convert.ToInt32(Console.ReadLine());
                    area2 = l1 * b1;
                    Console.WriteLine("Area of rectangle: " + area2);
                    break;


            }
            Console.ReadKey();
        }
    }
}
