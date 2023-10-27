//5. Write a C# Sharp program in to count duplicate elements in an array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_duplicate5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3];
            int cnt = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter Number: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine("element: {0} - {1}", i, arr1[i]);
            }
            for(int i=0; i < 3; i++)
            {
                for(int j = i+1; j < 3; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        cnt++;
                        break;

                    }
                }

            }
            Console.WriteLine("{0} ", cnt);




            Console.ReadKey();
        }
    }
}
