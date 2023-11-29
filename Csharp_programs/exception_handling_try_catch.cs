using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling_try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            Console.Write("Enter num: ");
            num=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n: ");
            n=Convert.ToInt32(Console.ReadLine());

            int res = 0;
            try
            {
                res = num / n;
            }
            catch {
                Console.WriteLine("Cannot divided by zero");
            }
            Console.WriteLine("Result: " + res);
            Console.WriteLine("Bye");

            Console.ReadKey();

        }
    }
}
