using System;

namespace table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cnt, result;
            Console.Write("Enter Number: ");
            num=Convert.ToInt32(Console.ReadLine());

            for(cnt=0;cnt<=10;cnt++)
            {
                result=num*cnt;
                Console.WriteLine(""+num + "*" + ""+cnt + "=" + ""+ result);

            }
            Console.ReadKey();
        }
    }
}
