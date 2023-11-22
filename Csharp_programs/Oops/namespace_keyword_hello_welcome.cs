using namespace_keyword_hello_welcome.first;
using namespace_keyword_hello_welcome.second;
using System;


namespace namespace_keyword_hello_welcome
{
    namespace first
    {
        class hello
        {
            public void sayhello()
            {
                Console.WriteLine("Hello from sayhello");
            }
        }
    }
    namespace second
    {
        class welcome
        {
            public void saywelcome()
            {
                Console.WriteLine("Hello from saywelcome");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            hello h=new hello();
            h.sayhello();
            welcome w = new welcome();
            w.saywelcome();

            Console.ReadKey();
        }
    }
}
