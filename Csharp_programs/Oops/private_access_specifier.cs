using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace private_access_specifier
{
    class Person
    {
        
    }
    internal class Program
    {
        private string name = "Kareena";

        private void msg(string msg)
        {
            Console.WriteLine("Hello " + msg);
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine("Hello " + p.name);
            p.msg("Rohit");

            Console.ReadKey();
        }
    }
}
