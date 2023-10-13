//6. Write a C# Sharp program to read the value of an integer m and display
//the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_mn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("Enter m: ");
            m=Convert.ToInt32(Console.ReadLine());
            if(m<0)
            {
                Console.WriteLine("The value of n is -1");
             }
            else if(m==0)
            {
                Console.WriteLine("The value of n is 0");
            }
            else if(m>0)
            {
                Console.WriteLine("The value of n is 1");
            }
            Console.ReadKey();

            

            
        }
    }
}
