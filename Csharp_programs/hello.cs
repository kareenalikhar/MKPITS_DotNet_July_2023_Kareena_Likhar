//1. Write a C# Sharp program to print Hello and your name in a separate line.

using System;

namespace helloname
{
    internal class Program
    {
        public static void Main()
        {
            string name;
            Console.WriteLine("Hello:");
            Console.WriteLine("Enter Name:");
            name = Console.ReadLine();
            Console.ReadKey();
        }
    }
}
