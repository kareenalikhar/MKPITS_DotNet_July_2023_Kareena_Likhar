using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passby_reference
{
    internal class Program
    {
        static void display(ref int num)
        {
            num = 20;
            Console.WriteLine("num inside method: "+num);
        }
        static void Main(string[] args)
        {
            int num = 10;
            display(ref num);
            Console.WriteLine("num after passing inside main: " + num);
            Console.ReadKey();
        }
    }
}
