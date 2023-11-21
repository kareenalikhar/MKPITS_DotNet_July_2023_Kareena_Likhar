using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_shape_draw
{
    interface shape
    {
        void draw();
    }
    class Rectangle:shape
    {
        public void draw()
        {
            Console.WriteLine("Code to draw rectangle...");
        }
    }
    class Circle:shape
    {
        public void draw()
        {
            Console.WriteLine("Code to draw circle...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            shape s;
            s=new Rectangle();
            s.draw();
            s=new Circle();
            s.draw();

            Console.ReadKey();
        }
    }
}
