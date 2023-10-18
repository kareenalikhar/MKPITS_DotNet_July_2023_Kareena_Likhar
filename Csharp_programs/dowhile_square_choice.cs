using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile_square_choice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1, square;
            char choice = 'y';
            do
            {
                Console.WriteLine("Enter Number: ");
                num = Convert.ToInt32(Console.ReadLine());
                square = num * num;
                Console.WriteLine("Square: " + square);
                Console.WriteLine("Do you want to continue, press y or n");
                choice = Convert.ToChar(Console.ReadLine());
            } while (choice == 'y' || choice == 'Y');

            Console.ReadKey();
        }
    }
}
