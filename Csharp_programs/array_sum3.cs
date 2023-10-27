//3. Write a program in C# Sharp to find the sum of all array elements.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_sum3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Number: ");
                num[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("element: {0} - {1}", i, num[i]);
            }

            for(int i=0;i<3; i++)
            {
                 sum = sum + num[i];
                
            }
            Console.WriteLine("\nSum of all elements stored in the array is : " + sum);

            Console.ReadKey();
        }
    }
}
