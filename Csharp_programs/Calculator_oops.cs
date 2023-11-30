using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execption_handling_user_define_calculator
{
    
    class Calculator
    {

        public double Result = 2;
        public void Addition(double num)
        {
            Result += num;
        }
        public void Substraction(double num)
        {
            Result -= num;
        }
        public void Multiplication(double num)
        {
            Result *= num;
        }
        public void Division(double num)
        {
            if(num!=0)
            {
                Result /= num;
            }
            else
            {
                Console.WriteLine("Number cannot divided by zero:");
            }
        }
        public void clear()
        {
            Result = 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator cal= new Calculator();

            cal.Addition(10);
            Console.WriteLine("Result: " + cal.Result);

            cal.Substraction(10);
            Console.WriteLine("Result: " + cal.Result);

            cal.Multiplication(10);
            Console.WriteLine("Result: " + cal.Result);

            cal.Division(10);
            Console.WriteLine("Result: " + cal.Result);

            cal.clear();
            Console.WriteLine("Result after clearing: " + cal.Result);

            Console.ReadKey();
        }
    }
}
