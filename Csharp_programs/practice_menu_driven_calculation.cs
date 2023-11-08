using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_menu_driven_calculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal n1, n2, res;
            int choice;
            Console.Write("Enter num1: ");
            n1=Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter num2: ");
            n2= Convert.ToDecimal(Console.ReadLine());
            Console.Write("Press 1 for Addition\n2 for Substraction\n3 for Multiplication\n4 for Division");
            choice = Convert.ToInt16(Console.ReadLine());

            if(choice == 1 ) 
            {
                res=n1 + n2;
                Console.WriteLine("Addition: " + res);
            }
            else if(choice == 2 )
            {
                res=n2 - n1;
                Console.WriteLine("Sub: " + res);
            }
            else if (choice == 3)
            {
                res = n2 * n1;
                Console.WriteLine("Mul: " + res);
            }
            else if (choice == 4)
            {
                res = n2 / n1;
                Console.WriteLine("Div: " + res);
            }
            Console.ReadKey();

        }
    }
}
