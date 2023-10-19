//4- wap to accept a no. and print table of that number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cnt = 1, result = 0;
            Console.WriteLine("Enter Num: ");
            num=Convert.ToInt32(Console.ReadLine());
            for(cnt=1; cnt<=10; cnt++)
            {
                result = num * cnt;
                Console.WriteLine("{0} * {1} = {2} ",num,cnt,result);
            }
            Console.ReadKey();
        }
    }
}
