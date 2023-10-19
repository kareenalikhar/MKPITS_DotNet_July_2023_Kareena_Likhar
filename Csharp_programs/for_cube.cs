//5. Write a C# Sharp program to display the cube of an integer up to given number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cnt = 1, cube = 1;
            Console.WriteLine("Enter num: ");
            num=Convert.ToInt32(Console.ReadLine());
            for(cnt=1; cnt<=num; cnt++)
            {
                cube = cnt * cnt * cnt;
                Console.WriteLine("Number is : {0} and cube of the {0} is :{1}",cnt,cube);
            }
            Console.ReadKey();
        }
    }
}
