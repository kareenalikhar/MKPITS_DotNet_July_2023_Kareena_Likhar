//16 - wap to accept a number and print whether it is aprime no or not

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,counter=2,flag=0;
            Console.WriteLine("Enter Number: ");
            num=Convert.ToInt32(Console.ReadLine());
            while (num > counter)
            {
                if (num % counter == 0)
                {
                    flag = 1;
                    break;
                }
                counter++;
            }
                if(flag==0)
                {
                    Console.WriteLine("It is prime no:)");
                }
                else
                { 
                    Console.WriteLine("It is not prime no:(");
                }

            
            Console.ReadKey();
            
        }
    }
}
