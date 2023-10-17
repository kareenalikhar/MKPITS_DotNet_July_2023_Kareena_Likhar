//Write a program in C# Sharp to read any digit, display in the word.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_digitinword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter number from 0 to 9: ");
            num=Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                case 8:
                    Console.WriteLine("Eight");
                    break;
                case 9:
                    Console.WriteLine("Nine");
                    break;
                case 10:
                    Console.WriteLine("Ten");
                    break;
                default:
                    Console.WriteLine("invalid number:");
                    break;
            }
            Console.ReadKey();
        }
    }
}
