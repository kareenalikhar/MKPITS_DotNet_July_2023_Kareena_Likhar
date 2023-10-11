using System;

namespace areaofrectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l, b, area;
            Console.WriteLine("Enter Length:");
            l= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth:");
            b= Convert.ToInt32(Console.ReadLine());
            area = l * b;
            Console.WriteLine("Area of rectangle = " + area);
            Console.ReadKey();
        }
    }
}
