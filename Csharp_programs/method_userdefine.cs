using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_userdifine
{
    internal class Program
    {
        static void display()
        {
            string name;
            Console.Write("Enter name: ");
            name= Console.ReadLine();
            Console.WriteLine("Welcome friend {0}!\nHave a nice day!", name);
        }
        static void Main(string[] args)
        {
            display();

            Console.ReadKey();
        }
    }
}
