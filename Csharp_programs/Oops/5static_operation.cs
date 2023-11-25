using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5static_operation
{
    static class MathOperation
    {
        public static int add(int n1, int n2)
        {
            return n1 + n2;
        }
        public static int multiply(int n1, int n2)
        {
            return n1 * n2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1: ");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition: "+MathOperation.add(n1,n2));
            Console.WriteLine("Multiplication: "+MathOperation.multiply(n1,n2));

            Console.ReadKey();
        }
    }
}
