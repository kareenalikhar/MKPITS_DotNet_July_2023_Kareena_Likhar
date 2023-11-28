using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collection_stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> s= new Stack<string>();
            s.Push("Message1");
            s.Push("Message2");
            s.Push("Message3");
            s.Push("Message4");

            foreach(string i in s)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Pop item: "+s.Peek());
            s.Pop();
            foreach (string i in s)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
