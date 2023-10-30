using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_foreach_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[3];
            int sum = 0;
            Console.WriteLine("Enter num: ");
            foreach(int i in num)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
                sum = sum + num[i];

            }    
            Console.WriteLine("Sum : "+sum);

            Console.ReadKey();
        }
    }
}
