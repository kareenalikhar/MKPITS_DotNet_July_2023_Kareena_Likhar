//22. Write C# Sharp program to read any Month Number in integer and display Month name.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_monthname
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month;
            Console.WriteLine("Month Number: ");
            month=Convert.ToInt32(Console.ReadLine());
            if(month == 1)
            {
                Console.WriteLine("January");
            }
            else if (month == 2)
            {
                Console.WriteLine("February");
            }
            else if (month == 3)
            {
                Console.WriteLine("March");
            }
            else if (month == 4)
            {
                Console.WriteLine("April");
            }
            else if (month == 5)
            {
                Console.WriteLine("May");
            }
            else if (month == 6)
            {
                Console.WriteLine("June");
            }
            else if (month == 7)
            {
                Console.WriteLine("July");
            }
            else if (month == 8)
            {
                Console.WriteLine("August");
            }
            else if (month == 9)
            {
                Console.WriteLine("September");
            }
            else if (month == 10)
            {
                Console.WriteLine("October");
            }
            else if (month == 11)
            {
                Console.WriteLine("November");
            }
            else if (month == 12)
            {
                Console.WriteLine("December");
            }
            Console.ReadKey();
        }
    }
}
