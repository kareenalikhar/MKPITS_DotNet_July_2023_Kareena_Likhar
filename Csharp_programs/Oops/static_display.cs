using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_display
{
      
    
    internal class Program
    {
        static void display()
        {
            Console.WriteLine("Hello from method display:");
        }
        static void Main(string[] args)
        {
            display();

            Console.ReadKey();
        }
    }
}
