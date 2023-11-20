using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_shape_rectangle_circle
{
    abstract class Shape
    {
        public abstract void draw();

    }
    class Rectangle:Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Rectangle....");
        }
    }
    class Circle: Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle();
            s.draw();
            s= new Circle();
            s.draw();

            Console.ReadLine();
        }
    }
}
