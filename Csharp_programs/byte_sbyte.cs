using System;

namespace byte_sbyte
{
    internal class byte_sbyte
    {
        static void Main()
        {
            byte b;
            Console.Write("Enter number: ");
            b= Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Byte Numbers = " + b);

            sbyte b1;
            Console.Write("Enter number: ");
            b1=Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("Sbyte Numbers = " + b1);
            Console.ReadKey();
        }
    }
}
