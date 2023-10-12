using System;

namespace long_ulong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long b;
            Console.WriteLine("Enter Number: ");
            b=Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Long Number: " + b);

            ulong b1;
            Console.WriteLine("Enter Number: ");
            b1=Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("Ulong Number: " + b1);
            Console.ReadKey();
        }
    }
}
