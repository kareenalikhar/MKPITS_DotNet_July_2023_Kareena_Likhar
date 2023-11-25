using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_interface_ishape
{
    interface IShape
    {
        void CalculateArea(int n1,int n2);
    }
    class Rectangle:IShape
    {
        public void CalculateArea(int n1,int n2)
        {
            int areaofrec = n1 * n2;
            Console.WriteLine("Area of Rectangle: " + areaofrec);

        }
    }

    class Triangle : IShape
    {
        public void CalculateArea(int n1, int n2)
        {
            float areaoftri = 0.5f*n1 * n2;
            Console.WriteLine("Area of Triangle: " + areaoftri);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n1: ");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            IShape s;
            s = new Rectangle();
            s.CalculateArea(n1,n2);
            s=new Triangle();
            s.CalculateArea(n1,n2);
            Console.ReadKey();
        }
    }
}
