using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace out_parameter_radius
{
    internal class Program
    {

        static void calculate(int radius, out float area, out float cir)
        {
            area = 3.14f * radius * radius;
            cir = 2 * 3.14f * radius;
        }
    static void Main(string[] args)
        {
            int radius;
            float area,circ;
            Console.WriteLine("Enter Radius: ");
            radius=Convert.ToInt32(Console.ReadLine());
            calculate(radius, out area, out circ);
            Console.WriteLine("Area : " + area);
            Console.WriteLine("Circ : " + circ);

            Console.ReadKey();
        }
    }
}
