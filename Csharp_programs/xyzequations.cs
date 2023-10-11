//10. Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.

using System;

namespace xyzequations
{
    internal class Program
    {
        static void Main()
        {
            int x, y, z, result;
            Console.Write("Enter value of X: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of Y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value of Z: ");
            z = Convert.ToInt32(Console.ReadLine());
            result = (x + y)*z;
            Console.WriteLine(result);
            result = x * y + y * z;
            Console.WriteLine(result);
            Console.ReadKey();


        }
    }
}
