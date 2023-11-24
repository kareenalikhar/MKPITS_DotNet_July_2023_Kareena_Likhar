using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_stack_push_peek_pop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s= new Stack();
            s.Push("Kareena");
            s.Push("Pooja");
            s.Push("Akash");
            s.Push("Chandrima");

            Console.WriteLine("Current stack: ");
            foreach(string var in s)
            {
                Console.WriteLine(var);
            }

            Console.WriteLine("-----------");
            Console.WriteLine("the pop value in stack : " + s.Peek());
            Console.WriteLine("After poping");
            s.Pop();
            foreach(string var in s)
            {
                Console.WriteLine(var);
            }
            Console.WriteLine("-----------");
            Console.WriteLine("the pop value in stack : " + s.Peek());
            Console.WriteLine("After poping");
            s.Pop();
            foreach (string var in s)
            {
                Console.WriteLine(var);
            }

            Console.ReadKey();
        }
    }
}
