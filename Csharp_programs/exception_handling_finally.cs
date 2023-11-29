using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling_finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num,n;
            Console.Write("Enter Num: ");
            num=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n: ");
            n=Convert.ToInt32(Console.ReadLine());
            int res = 0;
            try
            {
                res = num / n;
            }
            catch
            {
                Console.WriteLine("Executing the catch block");
                Console.WriteLine("Cannot divided by zero");
            }
            finally
            {
                Console.WriteLine("Executing the finally block");
                Console.WriteLine("Result: "+res);
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
