using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace one_parameter_factorial
{
    internal class Program
    {
        static void factorial(int num)
        {
            int fact=1;
            while (num > 0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("Factorial = " + fact);
        }
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            factorial(number);

            Console.ReadKey();
        }
    }
}
