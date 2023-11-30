using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling_class_calculator
{
    class Calculator
    {
        public double Result ;
        public void Addition(double n1,double n2)
        {
            Result = n1 + n2;
            Console.WriteLine("Result: " + Result);
        }
        public void Sub(double n1, double n2)
        {
            Result = n1 - n2;
            Console.WriteLine("Result: " + Result);
        }
        public void Mul(double n1, double n2)
        {
            Result = n1 * n2;
            Console.WriteLine("Result: " + Result);
        }
        public void Div(double n1, double n2)
        {
            if (n2!=0)
            {
                Result = n1 /n2;
                Console.WriteLine("Result: " + Result);
            }
            else
            {
                Console.WriteLine("Cannot divided by zero");
            }
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Choice: ");
                    string choice = Console.ReadLine();
                    Calculator c = new Calculator();
                    Console.Write("Enter n1: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter n2: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    

                    if (choice == "+")
                    {
                        c.Addition(num1, num2);
                    }
                    else if (choice == "-")
                    {
                        c.Sub(num1, num2);
                    }
                    else if (choice == "*")
                    {
                        c.Mul(num1, num2);
                    }
                    else if (choice == "/")
                    {
                        c.Div(num1, num2);
                    }
                  
                }

                catch (Exception ee)
                {
                    Console.WriteLine(ee.ToString());
                }

            }
            Console.ReadLine();
        }
    }
}
