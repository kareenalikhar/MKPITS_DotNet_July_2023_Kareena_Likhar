//1- create a method with one int parameter to print table of a number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_table
{
    internal class Program
    {
        static int table(int num)
        {
            int result = 0;
            int cnt = 1;
            while (cnt <= 10) 
            {
                result = num * cnt;
                Console.WriteLine(result);
                cnt++;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number: ");
            num=Convert.ToInt32(Console.ReadLine());
            int result=table(num);

            Console.ReadKey();
        }
    }
}
