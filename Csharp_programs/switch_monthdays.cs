//Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_monthdays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days;
            Console.Write("Enter Month in numbers: ");
            days = Convert.ToInt32(Console.ReadLine()); 
            switch(days)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("Month have 31 days:)");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Month have 30 days:)");
                    break;
                case 2:
                    Console.WriteLine("Month have 28 or 29 days:)");
                    break;
                default:
                    Console.WriteLine("Invalid month number:");
                    break;
            }
            Console.ReadKey();
        }
    }
}
