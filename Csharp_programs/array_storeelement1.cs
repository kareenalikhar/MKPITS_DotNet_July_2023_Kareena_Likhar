//1. Write a C# Sharp program that stores elements in an array and prints them.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_storeelement1
{
    internal class Program
    {
        int i = 0;
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for(int i=0;i<10;i++)
            {
                Console.Write("Enter Number: ");
                num[i]=Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("\n");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("element: {0} - {1}", i, num[i]);
            }
            Console.WriteLine("\n");
            Console.Write("Elements in array are: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", num[i]);
            }
            Console.ReadKey();
        }
    }
}
