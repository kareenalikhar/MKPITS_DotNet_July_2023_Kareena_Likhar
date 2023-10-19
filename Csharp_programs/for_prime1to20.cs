//9 wap to print prime no between 1 and 20

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_prime1to20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("prime no: 2");
            int num, counter, flag = 0;
            for(num=3;num<=20;num++)
            {
                flag = 0;
                counter = 2;
                for(counter=2;counter<num;counter++)
                {
                    if(num%2==0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if(flag==0)
                {
                    Console.WriteLine("prime no: "+num);
                }
            }
            Console.ReadKey();
        }
    }
}
