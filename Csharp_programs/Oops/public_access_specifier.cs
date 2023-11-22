using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_access_specifier_public
{
    public class publicTest
    {
        public string name="Kareena";
        public void msg(string msg)
        { 
            Console.WriteLine("Hello");
        
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            publicTest test = new publicTest();
            Console.WriteLine("Hello "+test.name);
            test.msg("Hello");
            Console.ReadKey();
        }
    }
}
