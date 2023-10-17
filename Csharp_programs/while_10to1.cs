//11- wap to print no from 10 to 1 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_10to1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=10;
            while(num>0)
            {
                Console.WriteLine(num);
                num--;
            }
            Console.ReadKey();
        }
    }
}
