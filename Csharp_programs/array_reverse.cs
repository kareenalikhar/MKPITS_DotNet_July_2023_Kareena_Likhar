//2. Write a C# Sharp program to read n values in an array and display them in reverse order.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Number: ");
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("element: {0} - {1}", i, num[i]);
            }

            Console.Write("The values store into the array :");
            for (int i = 0; i <3; i++)
            {
                Console.Write("{0} ", num[i]);
            }

            Console.Write("\nThe values store into the array in reverse are :");
            for (int i = 2; i >= 0; i--)
            {
                Console.Write("{0} ", num[i]);
            }
            Console.ReadKey();
        }
    }
}
