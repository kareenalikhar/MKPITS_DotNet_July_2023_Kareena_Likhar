//5. Write a C# Sharp program to display the cube of an integer up to given number.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_cube
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, counter=1, cube=1;
            Console.WriteLine("Enter Number: ");
            num=Convert.ToInt32(Console.ReadLine());
            while(num>=counter)
            {
                cube = counter * counter * counter;
                Console.WriteLine("Number is : {0} and cube of the {0} is :{1}",counter,cube);
                counter++;
            }

            Console.ReadKey();
        }
    }
}
