using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_float
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] num = new float[3];
            float sum = 0.0f;
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Enter Number: ");
                num[i] =Convert.ToSingle(Console.ReadLine());
            }
            for(int i=0;i<3; i++)
            {
                sum = sum + num[i];
            }
            Console.WriteLine("Sum of float variable: "+sum);

            Console.ReadKey();
        }
    }
}
