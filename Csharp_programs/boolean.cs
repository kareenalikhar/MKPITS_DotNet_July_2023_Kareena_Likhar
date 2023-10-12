using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Boolean b=true;
            Console.WriteLine("true or false: ");
            b=Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Boolean: " + b);
            Console.ReadKey();
        }
    }
}
