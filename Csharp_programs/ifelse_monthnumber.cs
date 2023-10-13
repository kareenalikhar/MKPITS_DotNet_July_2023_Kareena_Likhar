//23. Write a program in C# Sharp to read any Month Number in integer and display the number of days for this month.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_monthnumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter month number: ");
            num=Convert.ToInt32(Console.ReadLine());
            if(num ==1 || num ==3 || num ==5 || num ==7 || num==8 || num==10 || num==12)
            {
                Console.WriteLine("Month have 31 days");
            }
            else
            {
                Console.WriteLine("Month have 30 days");
            }
            Console.ReadKey();
        }
    }
}
