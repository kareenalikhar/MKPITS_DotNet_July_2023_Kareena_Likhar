using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_method_company_francise
{
    class Company
    {
        public string name = "Mkcl";
        public void display()
        {
            Console.WriteLine("Company Name: " + name);
        }
    }
    class franchise:Company
    {
        public string name = "Mkpits";
        public void display()
        {
            base.display();
            Console.WriteLine("Francise Name: " + name);
        }
    }                    
    internal class Program
    {
        static void Main(string[] args)
        {
            franchise f= new franchise();
            f.display();
            Console.ReadKey();
        }
    }
}
