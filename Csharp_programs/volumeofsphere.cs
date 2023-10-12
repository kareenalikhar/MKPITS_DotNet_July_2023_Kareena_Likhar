using System;

namespace volume
{
    internal class Volume
    {
        static void Main(string[] args)
        {
            int radius;
            float sur, sph;

            Console.Write("Enter Radius : ");
            radius = Convert.ToInt32(Console.ReadLine());

            sur = 4 * 3.14f * radius * radius;
            sph = 4 / 3 * 3.14f * radius * radius * radius;

            Console.WriteLine("Surface of volume = " + sur);
            Console.Write("Volume of sphere = " + sph);

            Console.ReadKey();
        }
    }
}