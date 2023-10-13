//7. Write a C# Sharp program to accept a person's height in centimeters and categorize them according to their height.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_height
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height;
            Console.WriteLine("height in cm: ");
            height=Convert.ToInt32(Console.ReadLine());
            if(height <= 135 )
            {
                Console.WriteLine("The person is Dwarf.");
            }
            else if(height >135 &&  height <=150)
            {
                Console.WriteLine("The person is Short:");
            }
            else
            {
                Console.WriteLine("The person is Tall.");
            }
            Console.ReadKey();
        }
    }
}
