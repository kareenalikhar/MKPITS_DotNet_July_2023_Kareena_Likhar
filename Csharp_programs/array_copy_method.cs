using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_copy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            int[] arr1 = new int[3];
            Console.WriteLine("Enter num: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Copy(arr,arr1,3);
            Console.WriteLine("After copy: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            Console.ReadKey();
        }
    }
}
