using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling_throw_catch
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
                    Console.WriteLine("age is greater or equal to 18");
                }
            }
            catch(OverflowException ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter smaller number:");
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.ToString());
                Console.WriteLine("Enter number greater than or equal to 18");
                age = Convert.ToInt32(Console.ReadLine());
            }
            finally
            {
                Console.WriteLine("Execution of finally block");
                Console.WriteLine("Age: "+age);
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
