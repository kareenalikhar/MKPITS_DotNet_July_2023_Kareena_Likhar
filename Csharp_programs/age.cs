//11. Write a C# Sharp program that takes an age (for example 20) as input and prints something like "You look older than 20".

using System;

namespace age
{
    internal class Program
    {
        static void Main()
        {
            int age, result;
            Console.Write("Enter Age: ");
            age=Convert.ToInt32(Console.ReadLine());
            if(age >= 20) 
            {
                Console.WriteLine("You are older than 20");
            }
            else 
            {
                Console.WriteLine("You are younger than 20");
            }
            Console.ReadKey();
        }
    }
}
