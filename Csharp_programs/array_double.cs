using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[3];
            double sum = 0;
            for(int i=0;i<3;i++)
            {
                Console.Write("Enter number: ");
                num[i] = Convert.ToDouble(Console.ReadLine());
            }
            for(int i=0;i<3; i++)
            {
                sum = sum + num[i];
            }
            Console.WriteLine("Sum: " + sum);

            Console.ReadKey();
        }
    }
}
