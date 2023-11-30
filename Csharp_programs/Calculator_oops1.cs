using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class calculator
    {
        public double Result = 4;

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
            if (num != 0)
            {
                Result /= num;
            }
            else
            {
                Console.WriteLine("Cannot divided by zero");
            }
        }
        public void Exponential(double exponent)
        {
            Result = Math.Pow(Result, exponent);
        }
        public void squareroot()
        {
            if (Result >= 0)
            {
                Result = Math.Sqrt(Result);
            }
            else
            {
                Console.WriteLine("Square root cannot be zero");
            }
        }
        public void clear()
        {
            Result = 0;
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                calculator c = new calculator();

                while (true)
                {
                    Console.WriteLine("Current result: " + c.Result);
                    Console.WriteLine("1.Add: ");
                    Console.WriteLine("2.Sub: ");
                    Console.WriteLine("3.Mul: ");
                    Console.WriteLine("4.Div: ");
                    Console.WriteLine("5.Exponent: ");
                    Console.WriteLine("6.Square: ");
                    Console.WriteLine("7.Clear: ");
                    Console.WriteLine("8.Exit: ");

                    Console.Write("Enter Choice: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            Console.Write("Enter number to add: ");
                            double addNum = Convert.ToDouble(Console.ReadLine());
                            c.Addition(addNum);
                            break;

                        case "2":
                            Console.Write("Enter number to subtract: ");
                            double subNum = Convert.ToDouble(Console.ReadLine());
                            c.Substraction(subNum);
                            break;

                        case "3":
                            Console.Write("Enter number to multiply: ");
                            double mulNum = Convert.ToDouble(Console.ReadLine());
                            c.Multiplication(mulNum);
                            break;

                        case "4":
                            Console.Write("Enter number to divide: ");
                            double divNum = Convert.ToDouble(Console.ReadLine());
                            c.Division(divNum);
                            break;

                        case "5":
                            Console.Write("Enter exponent: ");
                            double exponent = Convert.ToDouble(Console.ReadLine());
                            c.Exponential(exponent);
                            break;

                        case "6":
                            c.squareroot();
                            break;

                        case "7":
                            c.clear();
                            break;

                        case "8":
                            Console.WriteLine("Exiting the calculator. Goodbye!");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }

                    Console.WriteLine();

                }
            }
        }
    }
}
