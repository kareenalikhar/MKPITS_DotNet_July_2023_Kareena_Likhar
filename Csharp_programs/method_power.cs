using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_power
{
    internal class Program
    {
        static void calculate(int num,int power)
        {
            int result = 1;

            for (int cnt = 1; cnt <= power; cnt++)
            {
                result = num * result;
                Console.WriteLine("Result: " + result);
            }
                
            
        }
        static void Main(string[] args)
        {
            int num=1, power=1;
            Console.WriteLine("Enter num: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter power: ");
            power = Convert.ToInt32(Console.ReadLine());
            calculate(num,power);

            Console.ReadKey();
        }
    }
}
