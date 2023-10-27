//4. Write a C# Sharp program to copy the elements of one array into another array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_copy4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Number: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("element: {0} - {1}", i, arr1[i]);
            }
            Console.Write("The elements stored in the first array are :");
            for (int i = 0; i < 3; i++)
            {
                arr2[i] = arr1[i];
                Console.Write("{0} ", arr1[i]);
            }
            Console.Write("\nThe elements copied into the second array are :");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }

            Console.ReadKey();
            
        }
    }
}
