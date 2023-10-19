//wap to accept a number and print odd no uptil that number  //5
//1 3 5 7 9


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_oddsum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cnt = 1;
            int sum = 1;
            Console.WriteLine("Enter number: ");
            num=Convert.ToInt32(Console.ReadLine());
            while(true)
            {
                if(num>=sum)
                {
                    if(cnt%2!=0)
                    {
                        Console.Write("{0},",cnt );
                        sum = sum + 1;
                    }
                }
                else
                {
                    break;
                }
                cnt++;
            }
            Console.ReadKey();
        }
    }
}
