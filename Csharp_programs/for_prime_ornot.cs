//3 wap to accept a number and print whether no .is prime or not 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_primeornot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cnt,flag=0;
            Console.WriteLine("Enter num: ");
            num=Convert.ToInt32(Console.ReadLine());
            for(cnt=2; cnt<num; cnt++)
            {
                if(num%cnt==0)
                {
                    flag = 1;
                    break;
                }
                
            }
            if (flag == 0)
            {
                Console.WriteLine("No is prime: ");
            }
            else
            {
                Console.WriteLine("No is not prime: ");
            }
            Console.ReadKey();
        }
    }
}
