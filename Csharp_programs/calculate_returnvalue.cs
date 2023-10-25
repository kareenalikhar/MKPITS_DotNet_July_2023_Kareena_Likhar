using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculate_returnvalue
{
    internal class Program
    {
        static int calculate(int num1, int num2,char op)
        {
            int result=0;
            if(op == '+')
            {
                result = num1+num2;
            }
            else if(op == '-')
            {
                result = num1-num2;
            }
            else if(op == '*') {
                result = num1 * num2;
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
            return result;
        }
        static void Main(string[] args)
        {
            int num1, num2;
            char op;
            Console.WriteLine("Enter Number1: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter +,-,*");
            op=Convert.ToChar(Console.ReadLine());
            int result=calculate(num1, num2, op);
            Console.WriteLine("Result: " + result);

            Console.ReadKey();

        }
    }
}
