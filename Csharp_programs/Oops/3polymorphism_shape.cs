using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3polymorphism_shape
{
    class Shape
    {
        public int n1;
        public int n2;
        public int rec;
        public float tri;

        public virtual void calculate(int n1,int n2)
        {
            Console.WriteLine("hello from calculate");
        }
        
    }
    class Rectangle: Shape
    {
        public override void calculate(int n1, int n2)
        {
            rec = n1 * n2;
            Console.WriteLine("Area of Rectangle: " + rec);
        }
    }
    class triangle : Shape
    {
        public override void calculate(int n1, int n2)
        {
            tri =0.5f* n1 * n2;
            Console.WriteLine("Area of triangle: " + tri);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Rectangle();
            s.calculate(5,2);
            Shape s2 = new triangle();
            s2.calculate(5, 2);

            Console.ReadKey();
            
        }
    }
}

