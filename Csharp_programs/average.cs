//9. Write a C# Sharp program that takes four numbers as input to calculate and print the average.

using System;

namespace average
{
    internal class Program
    {
        public static void Main()
        {
            int n1, n2, n3, n4, average;
            Console.WriteLine("Enter 4 numbers: ");
            n1=Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            n4 = Convert.ToInt32(Console.ReadLine());
            average=(n1+n2+n3+n4)/4;
            Console.WriteLine("Average = " + average);
            Console.ReadKey();
        }
    }
}
