using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equations2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            
            Console.WriteLine("Enter value of Y: ");
            y=Convert.ToInt32(Console.ReadLine());

            x = (y * y) + 2 * y + 1;
            Console.WriteLine("Value of X: " + x);
            Console.ReadKey();

        }
    }
}
