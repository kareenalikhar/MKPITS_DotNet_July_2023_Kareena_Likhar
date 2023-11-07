using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading_different_parameter_calculate
{
    class Calculate
    {
        public void addition(int n1,int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("Addition of int : " + res);
        }
        public void addition(float n1,float n2)
        {
            float res = n1 + n2;
            Console.WriteLine("Addition is float: " + res);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate c= new Calculate();
            Console.WriteLine("Addition of integer");
            Console.Write("Enter n1:");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter n2:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            c.addition(n1, n2);

            Console.WriteLine("Addition of float");
            c.addition(3.2f, 4.3f);

            Console.ReadKey();
        }
    }
}
