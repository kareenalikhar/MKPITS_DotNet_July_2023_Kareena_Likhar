using System;

namespace squareprogram
{
    internal class SquareProgram
    {
        public static void Main()
        {
            int num, square;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            square = num * num;
            Console.WriteLine("Square = " + square);
            Console.ReadKey();
        }
    }
}
