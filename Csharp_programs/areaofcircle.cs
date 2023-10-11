using System;

namespace areaofcircle
{
    internal class Program
    {
        public static void Main()
        {
            int radius;
            float area, circ;
            Console.WriteLine("Enter Radius : ");
            radius=Convert.ToInt32(Console.ReadLine());
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
            Console.WriteLine("Area = " + area);
            Console.WriteLine("Circumference = " + circ);
            Console.ReadKey();
        }
    }
}
