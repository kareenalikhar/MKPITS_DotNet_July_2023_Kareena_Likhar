using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operators1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, result;
            char op;
            Console.WriteLine("Enter num1: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2: ");
            num2=Convert.ToInt32(Console.ReadLine());

            result = num1 + num2;
            Console.WriteLine("addition: " + result);
            result = num1 - num2;
            Console.WriteLine("Substraction: " + result);
            result = num1 * num2;
            Console.WriteLine("Substraction: " + result);
            result = num1 / num2;
            Console.WriteLine("Substraction: " + result);

            Console.ReadKey();


        }
    }
}
