//wap to print no from 1 to 10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_1to10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=1;
            while(num<=10 )
            {
                Console.WriteLine(num);
                num++;
            }
            Console.ReadKey();
        }
    }
}
