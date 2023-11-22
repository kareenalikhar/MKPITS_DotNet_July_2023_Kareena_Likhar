using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protected_internal_access_specifier
{
    class Person
    {
        protected internal string name = "Kareena";
        protected internal void msg(string name)
        {
            Console.WriteLine("Hello "+name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine("Hello "+p.name);
            p.msg("Rohit");
            Console.ReadKey();


        }
    }
}
