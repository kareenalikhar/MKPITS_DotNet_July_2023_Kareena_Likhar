using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_queue_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q= new Queue();
            q.Enqueue("Kareena");
            q.Enqueue("Akash");
            q.Enqueue("Pooja");
            q.Enqueue("Chandrima");

            foreach(string s in q)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("______________");
            Console.WriteLine("After Removing: ");
            q.Dequeue();

            foreach(string s in q) 
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("______________");
            Console.WriteLine("After Removing: ");
            q.Dequeue();

            foreach (string s in q)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();


        }
    }
}
