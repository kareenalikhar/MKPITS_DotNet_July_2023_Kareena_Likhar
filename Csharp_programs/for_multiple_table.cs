//6. Write a program in C# Sharp to display the multiplication table of a given integer.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_multiple_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cnt, result = 0;
            Console.WriteLine("Enter number: ");
            num=Convert.ToInt32(Console.ReadLine());
            for(cnt=1;cnt<=10;cnt++)
            {
                result = num * cnt;
                Console.WriteLine("{0} x {1} = {2}", num, cnt, result);
            }
            Console.ReadKey();
        }
    }
}
