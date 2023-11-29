using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling_throw_age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            try
            {
                Console.Write("Enter Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                if(age<18)
                {
                    Console.WriteLine("Age should be greater or equal to 18");
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter age 18 or greater");
                age=Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("Executing finally block");
                Console.WriteLine("Age: " + age);
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
