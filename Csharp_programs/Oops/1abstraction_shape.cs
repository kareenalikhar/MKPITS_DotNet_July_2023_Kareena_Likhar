using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1abstraction_shape
{
    abstract class Shape
    {
        public abstract void draw();
    }
    class Circle:Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Circle....");
        }
    }
    class Square : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Drawing Square....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s;
            s=new Circle();
            s.draw();
            s=new Square();
            s.draw();

            Console.ReadLine();
        }
    }
}
