//14 wap to print odd numbers between 20 and 30 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_odd20to30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=20;
            while(num<=30)
            {
                if(num%2 !=0)
                {
                    Console.WriteLine("odd no: " + num);
                }
                num++;
            }
            Console.ReadKey();
        }
    }
}
