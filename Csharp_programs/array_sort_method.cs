﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];
            Console.WriteLine("Enter number: ");
            for(int i=0; i<arr.Length; i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine("After sorting: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
