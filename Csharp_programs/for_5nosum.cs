//5- wap to accept 5 no. and print the sum of 5 no.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_5nosum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            for(int cnt=1;cnt<=5;cnt++)
            {
                Console.Write("Enter num: ");
                num=Convert.ToInt32(Console.ReadLine());
                sum=sum+cnt;
            }
            Console.WriteLine("Sum: " + sum);
            Console.ReadKey();
        }
    }
}
