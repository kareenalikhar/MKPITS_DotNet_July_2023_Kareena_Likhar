//15 wap to accept a number and print the table of that number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, counter=1,result;
            Console.WriteLine("Enter Number: ");
            num=Convert.ToInt32(Console.ReadLine());
            while(counter < 10) 
            {
                result = num * counter;
                Console.WriteLine("{0} * {1} = {2}",num,counter,result);
                counter++;
            }
            Console.ReadKey();
        }
    }
}
