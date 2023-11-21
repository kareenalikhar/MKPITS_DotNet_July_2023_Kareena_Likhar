using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_drawable_public
{
    public interface drawable
    {
         void draw();
    }
    public class Rectangle:drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle:");
        }
    }
    public class Circle : drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing circle:");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            drawable d;
            d=new Rectangle();
            d.draw();
            d=new Circle(); 
            d.draw();

            Console.ReadLine();
        }
    }
}
