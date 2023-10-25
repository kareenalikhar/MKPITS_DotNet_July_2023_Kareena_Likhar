//4. Write a program in C# Sharp to create a function to swap two integer numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_swapping
{
    internal class Program
    {
        static int swap(int x,int y)
        {
            int res=0;
            int temp=0;

            temp=x;
            x=y;
            y=temp;
            Console.WriteLine("Numbers after swapping: {0} , {1} ", x, y);
            return res;

        }
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter num1: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num1: ");
            y = Convert.ToInt32(Console.ReadLine());
            int res=swap(x,y);

            Console.ReadKey();
        }
    }
}
