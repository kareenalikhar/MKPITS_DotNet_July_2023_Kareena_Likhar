using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphism_baseclass_childclass
{
    class baseclass
    {
        public virtual void show()
        {
            Console.WriteLine("Hello from baseclass");
        }
    }
    class childclass:baseclass
    {
        public override void show()
        {
            Console.WriteLine("Hello from childclass");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            baseclass b= new childclass();
            b.show();

            Console.ReadKey();
        }
    }
}
