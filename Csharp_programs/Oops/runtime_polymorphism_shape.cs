using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphism_shape
{
    class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("Drawing....");
        }
    }
    class Rectangle:Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Rectangle....");
        }
    }
    class Circle : Shape
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
            s= new Rectangle();
            s.draw();

            s= new Circle();
            s.draw();

            Console.ReadKey();
        }
    }
}
