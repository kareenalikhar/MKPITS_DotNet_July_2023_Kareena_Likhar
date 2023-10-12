using System;

namespace reverse
{
    internal class Reverse
    {
        static void Main(string[] args)
        {
            char letter1, letter2, letter3;

            Console.Write("Enter letter1 :");
            letter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter letter2 :");
            letter2 = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter letter3 :");
            letter3 = Convert.ToChar(Console.ReadLine());

            Console.Write(" " + letter3);
            Console.Write(" " + letter2);
            Console.Write(" " + letter1);

            Console.ReadKey();
        }
    }
}