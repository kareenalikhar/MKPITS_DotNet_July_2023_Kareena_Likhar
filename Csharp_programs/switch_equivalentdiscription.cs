//Write a program in C# Sharp to accept a grade and declare the equivalent description :

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_equivalentdiscription
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("Enter character (e,v,g,a,f): ");
            ch=Convert.ToChar(Console.ReadLine());
            switch(ch)
            {
                case 'e':
                    Console.WriteLine("Excellent");
                    break;
                case 'v':
                    Console.WriteLine("Very good");
                    break;
                case 'g':
                    Console.WriteLine("Good");
                    break;
                case 'a':
                    Console.WriteLine("Average");
                    break;
                case 'f':
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Invalid character:(");
                    break;
            }
            Console.ReadKey();
        }
    }
}
