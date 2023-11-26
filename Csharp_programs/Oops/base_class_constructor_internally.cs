using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_class_constructor_internally
{
    internal class Program
    {
        class Company
        {
            public string name = "mkcl";
            public Company() 
            {
                Console.WriteLine("Base class Constructor");
                Console.WriteLine("Comapny Name: " + name);
            
            }

        }
        class francise:Company
        {
            public string name = "mkpits";
            public francise()
            {
                Console.WriteLine("Derived class Constructor");
                Console.WriteLine("Francise Name: " + name);

            }

        }
        static void Main(string[] args)
        {
            francise f=new francise();
            Console.ReadKey();
        }
    }
}
