using System;

namespace perimeter
{
    internal class perimeter
    {
        static void Main()
        {
            int radius;
            float area, peri;

            Console.WriteLine("Enter radius : ");
            radius = Convert.ToInt32(Console.ReadLine());

            area = 3.14f * radius * radius;
            peri = 2 * 3.14f * radius;

            Console.WriteLine("Area of circle = " + area);
            Console.WriteLine("perimeter of circle = " + peri);

            Console.ReadKey();





        }
    }
}