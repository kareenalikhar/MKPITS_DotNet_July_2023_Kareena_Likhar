using System;

namespace short_ushort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short b;
            Console.WriteLine("Enter number: ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Short Number: " + b);

            ushort b1;
            Console.WriteLine("Enter Number: ");
            b1=Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Ushort Number: " + b1) ;
            Console.ReadKey();
        }
    }
}
