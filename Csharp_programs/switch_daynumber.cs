//wap to accept a day number and print dayname

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_daynumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dayno;
            Console.Write("Enter Dayno: ");
            dayno=Convert.ToInt32(Console.ReadLine());
            switch(dayno)
            {
                case 1:
                    Console.WriteLine("Sunday :)");
                    break;
                case 2:
                    Console.WriteLine("Monday :)");
                    break;
                case 3:
                    Console.WriteLine("Tuesday :)");
                    break;
                case 4:
                    Console.WriteLine("Wednesday :)");
                    break;
                case 5:
                    Console.WriteLine("Thusday :)");
                    break;
                case 6:
                    Console.WriteLine("Friday :)");
                    break;
                case 7:
                    Console.WriteLine("Saturday :)");
                    break;
                default:
                    Console.WriteLine("Oops! Its Invalid Dayno..... ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
