//wap to print 1 to 10 using for loop

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_print1to10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            for(num=1;num<=10;num++)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
        }
    }
}
