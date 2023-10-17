//13 wap to print even numbers between 1 and 10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_even1to10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=1;
            while(num <= 10)
            {
                if(num%2==0)
                {
                    Console.WriteLine("even no: "+num);
                }
                num++;

            }
            Console.ReadKey();
        }
    }
}
