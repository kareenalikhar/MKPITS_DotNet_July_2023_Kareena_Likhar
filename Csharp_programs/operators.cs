//7. Write a C# Sharp program to print on screen the output of adding,
//subtracting, multiplying and dividing two numbers entered by the user.

using System;

namespace operators
{
    internal class Program
    {
        public static void Main()
        {
            int num1, num2, result;
            Console.Write("Enter num1: ");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter num2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            result = num1 + num2;
            Console.WriteLine("" +num1 + "+" + ""+num2 + "=" + ""+result);
            result = num1 - num2;
            Console.WriteLine("" + num1 + "-" + "" + num2 + "=" + "" + result);
            result = num1 * num2;
            Console.WriteLine("" + num1 + "*" + "" + num2 + "=" + "" + result);
            result = num1 / num2;
            Console.WriteLine("" + num1 + "/" + "" + num2 + "=" + "" + result);
            result = num1 % num2;
            Console.WriteLine("" + num1 + "%" + "" + num2 + "=" + "" + result);
            Console.ReadLine();
            


        }
    }
}
