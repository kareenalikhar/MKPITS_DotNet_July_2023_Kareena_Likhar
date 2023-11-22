using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internal_access_specifier_person
{
     class Person
    {
        internal string name="Kareena";
        internal void msg(string name)
        {
            
            Console.WriteLine("Hello " +name);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine("Hello " + p.name);
            p.msg("Kareena");

            Console.ReadKey();
        }
    }
}
