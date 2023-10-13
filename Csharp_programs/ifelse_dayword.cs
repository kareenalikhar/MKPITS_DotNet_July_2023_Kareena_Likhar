//20. Write a C# Sharp program to read any day number as an integer and display the name of the day as a word.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_dayword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day;
            Console.WriteLine("Enter day:");
            day=Convert.ToInt32(Console.ReadLine());
            if(day==1)
            {
                Console.WriteLine("Sunday");
            }
            else if (day == 2)
            {
                Console.WriteLine("Monday");
            }
            else if (day == 3)
            {
                Console.WriteLine("Tuesday");
            }
            else if (day == 4)
            {
                Console.WriteLine("Wednesday");
            }
            else if (day == 5)
            {
                Console.WriteLine("Thusday");
            }
            else if (day == 6)
            {
                Console.WriteLine("Friday");
            }
            else if (day == 7)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("Invalid day:");
            }
            Console.ReadKey();
        }
    }
}
