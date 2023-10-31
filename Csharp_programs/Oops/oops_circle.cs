using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_circle
{
    class Circle
    {
        int radius;
        float area;
        float circ;
        public void getdata(int radius)
        {
            this.radius = radius;
            area = 3.14f * radius * radius;
            circ = 2 * 3.14f * radius;
        }
        public void displaydata()
        {
            Console.WriteLine("Area: " + area);
            Console.WriteLine("Circumference: " + circ);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.getdata(7);
            circle.displaydata();

            Console.ReadKey();
        }
    }
}
