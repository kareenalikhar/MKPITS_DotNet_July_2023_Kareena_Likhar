//6. Write a program in C# Sharp to create a function to display the n number Fibonacci sequence.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_fibonachi
{
    internal class Program
    {
        static int fibo(int num)
        {
            int num1 = 0;
            int num2 = 1;
            int i = 3;
            Console.Write("Fibonachi series: {0},{1},", num1, num2);
            int res = num1 + num2;

            while (i<=num)
            {
                num1 = num2;
                num2 = res;
                Console.Write("{0},", res);
                res = num1 + num2;
                i++;
            }
            return res;
        }
        static void Main(string[] args)
        {
            
            int num = 0;
            Console.WriteLine("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            int res = fibo(num);

            Console.ReadKey();

        }
    }
}
