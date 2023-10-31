using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_rectangle
{
    class Rectangle
    {
        int width;
        int height;
        int area;

        public void getdata(int width, int height) 
        {
            this.width = width;
            this.height = height;
            area = width*height;
        }
        public void displaydata()
        {
            Console.WriteLine("width: "+width);
            Console.WriteLine("height: " + width);
            Console.WriteLine("Area: " + area);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.getdata(5, 10);
            rec.displaydata();

            Console.ReadKey();
        }
    }
}
