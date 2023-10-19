//3. Write a C# Sharp program that displays the sum of n natural numbers.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_sumofnno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cnt, sum = 1;
            Console.Write("Enter Number: ");
            num=Convert.ToInt32(Console.ReadLine());
            for(cnt=1; cnt<=num; cnt++)
            {
                Console.Write("{0},",cnt);
                sum=sum+cnt;
            }
            Console.WriteLine("\nSum = " + sum);
            Console.ReadKey();
        }
    }
}
