//5. Write a C# Sharp program to swap two numbers.

using System;

namespace swapping2num
{
    internal class Program
    {
        public static void Main()
        { 
            int num1, num2, temp;
            Console.Write("Enter num1: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2: ");
            num2=Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("After Swapping:");
            Console.WriteLine("num1= " + num1);
            Console.WriteLine("num2= " + num2);
            Console.ReadKey();
        }
    }
}
