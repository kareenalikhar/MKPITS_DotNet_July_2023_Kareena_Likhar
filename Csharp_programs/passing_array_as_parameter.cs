using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passing_array_as_parameter
{
    internal class Program
    {
        static void display(int[] num)
        {
            int sum = 0;
            for(int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];
            }
            Console.WriteLine("Sum : "+sum);
        }
        static void Main(string[] args)
        {
            int[] num = new int[3];
            Console.WriteLine("Enter num: ");
            for(int i = 0;i < num.Length;i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            display(num);
            Console.ReadKey();
        }

    }
}
