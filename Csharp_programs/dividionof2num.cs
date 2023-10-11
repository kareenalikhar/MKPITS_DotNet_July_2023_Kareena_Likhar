//3. Write a C# Sharp program to print the result of dividing two numbers.

using System;

namespace division2num
{
    internal class Program
    {
        static void Main()
        {
            int num1, num2, div;
            Console.Write("Enter num1 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2 : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            div = num1 / num2;
            Console.WriteLine("Division : " + div);
            Console.ReadKey();
        }
    }
}
