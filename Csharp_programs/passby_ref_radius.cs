using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passbyref_radius
{
    internal class Program
    {
        static void calculate(int radius, ref float area, ref float cir)
        {
            area = 3.14f * radius * radius;
            cir = 2 * 3.14f * radius;
        }
        static void Main(string[] args)
        {
            int radius;
            float area=0, cir=0;
            Console.WriteLine("Enter Radius: ");
            radius=Convert.ToInt32(Console.ReadLine());
            calculate(radius, ref area, ref cir);
            Console.WriteLine("Area : " + area);
            Console.WriteLine("Circumference: " + cir);

            Console.ReadKey();
        }
    }
}
