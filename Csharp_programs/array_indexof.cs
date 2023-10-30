using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_indexof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };
            int l=Array.IndexOf(arr, 3);
            Console.WriteLine("Index of 3: "+l);
            Console.ReadKey();
        }
    }
}
