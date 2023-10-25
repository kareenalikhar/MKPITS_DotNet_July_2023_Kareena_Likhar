//2- create a method with one int parameter to print whether no. is prime or not

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_primeornot
{
    internal class Program
    {
        static int prime(int num)
        {
            int result = 0;
            int cnt;
            int flag = 0;
            
              for(cnt=2; cnt<num; cnt++) 
              {
                    if(num% cnt == 0)
                    {
                            flag = 1;
                            break;
                    }
            
              }
              if(flag == 0)
                {
                    Console.WriteLine("It is prime no");
                }
              else 
                { 
                    Console.WriteLine("It is not a prime no");
                }
              return result;
        }
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number: ");
            num=Convert.ToInt32(Console.ReadLine());
            int result= prime(num);

            Console.ReadKey();
        }
    }
}
