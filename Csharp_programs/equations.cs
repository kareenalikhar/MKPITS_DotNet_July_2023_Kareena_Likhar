//4. Write a C# Sharp program to print the results of the specified operations.

using System;

namespace equation1
{
    internal class Program
    {
        public static void Main()
        {
            int result;
            result = -1 + 4 * 6;
            Console.WriteLine("Result = " +result);

            result = (35 + 5) % 7;
            Console.WriteLine("Result = " + result);

            result = 14 + -4 * 6 / 11;
            Console.WriteLine("Result = " + result);

            result = 2 + 15 / 6 * 1 - 7 % 2;
            Console.WriteLine("Result = " + result);
            Console.ReadKey();
        }
    }
}
