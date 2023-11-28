using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collection_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q=new Queue<string>();
            q.Enqueue("Message1");
            q.Enqueue("Message2");
            q.Enqueue("Message3");
            q.Enqueue("Message4");


            foreach(string s  in q)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("After Dequeue");
            Console.WriteLine("Dequeue: " + q.Dequeue());
            foreach (string s in q)
            {
                Console.WriteLine(s);
            }



            Console.ReadKey();


        }
    }
}
