//1- wap to  print 1 to 5 using do while loop

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile_5num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=1;
            do
            {
                Console.WriteLine(num);
                num++;
            } while (num <= 5);
            Console.ReadKey();
        }
    }
}
