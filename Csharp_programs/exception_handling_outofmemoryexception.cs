using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling_outofmemoryexception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name ="Kareena";
            string subject="Csharpabc";

            Console.WriteLine("length of Name: "+name.Length);
            StringBuilder sb= new StringBuilder(name.Length,name.Length);
            try
            {
                sb.Append(subject);
            }
            catch(ArgumentOutOfRangeException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
