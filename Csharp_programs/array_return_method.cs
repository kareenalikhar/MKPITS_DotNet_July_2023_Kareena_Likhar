using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_return_method
{
    internal class Program
    {
        static int[] returnarray()
        {
            int[] num = new int[3];
            Console.WriteLine("Enter num: ");
            for(int i = 0;i<num.Length;i++)
            {
                num[i] =Convert.ToInt32(Console.ReadLine());
            }
            return num;
        }
        static void Main(string[] args)
        {
            int[] res = returnarray();
            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();

        }
    }
}
