﻿//10. Write a C# Sharp program to sort elements of an array in ascending order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_decending11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = 0;
            int[] arr = new int[3];
            Console.WriteLine("Enter Number: ");
            for (int i = 0; i < 3; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Decending: ");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
            Console.ReadKey();
        }
    }
}
