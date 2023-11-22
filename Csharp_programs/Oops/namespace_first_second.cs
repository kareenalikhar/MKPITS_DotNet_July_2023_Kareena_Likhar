using namespace_keywords.First;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace namespace_keywords
{
    namespace First
    {
        class Hello
        {
            public void sayhello()
            {
                Console.WriteLine("Hello from first namespace");
            }
        }
    }
    namespace Second
    {
        class Hello
        {
            public void sayhello()
            {
                Console.WriteLine("Hello from Second namespace");
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            First.Hello h=new First.Hello();
            h.sayhello();
            Second.Hello h1=new Second.Hello();
            h1.sayhello();

            Console.ReadKey();
        }
    }
}
