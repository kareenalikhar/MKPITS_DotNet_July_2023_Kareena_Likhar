//9. Write a C# Sharp program to accept a coordinate point in an XY coordinate system
//and determine in which quadrant the coordinate point lies.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_quadrant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Input the value for X coordinate : ");
            x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the value for Y coordinate : ");
            y = Convert.ToInt32(Console.ReadLine());
            if(x>0 && y>0)
            {
                Console.WriteLine("The coordinate point({0} {1}) lies in the First quadrant.",x,y);
            }
            else if (x<0 && y>0)
            {
                Console.WriteLine("The coordinate point({0} {1}) lies in the Second quadrant.", x, y);
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The coordinate point({0} {1}) lies in the Third quadrant.", x, y);
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The coordinate point({0} {1}) lies in the Second quadrant.", x, y);
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("The coordinate point({0} {1}) lies in Origin.", x, y);
            }
            Console.ReadKey();

        }
    }
}
