using System;

namespace int_uint
{
    internal class Program
    {
        static void Main()
        {
            int b;
            Console.Write("Enter Number: ");
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Int Number: " + b);

            uint b1;
            Console.Write("Enter Number: ");
            b1=Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Uint Number: "+b1);
            Console.ReadKey();
        }
    }
}
