//4. Write a C# Sharp program to find out whether a given year is a leap year or not.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter year: ");
            year=Convert.ToInt32(Console.ReadLine());
            if(year %4==0)
            {
                Console.WriteLine("Year is leap: ");
            }
            else
            {
                Console.WriteLine("Year is not leap: ");
            }
            Console.ReadKey();
        }
    }
}
