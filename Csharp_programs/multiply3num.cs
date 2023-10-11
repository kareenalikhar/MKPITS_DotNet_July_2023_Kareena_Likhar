//6. Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.

using System;

namespace multiply3num
{
    internal class Program
    {
        static void Main()
        {
            int num1, num2, num3, multiply;
            Console.Write("Input the first number to multiply: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            multiply=num1*num2*num3;
            Console.WriteLine("Multiplication of 3 numbers: " + multiply);
            Console.ReadKey();

        }
    }
}
