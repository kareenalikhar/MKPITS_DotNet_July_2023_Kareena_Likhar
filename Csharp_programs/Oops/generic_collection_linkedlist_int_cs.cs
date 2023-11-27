using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collection_linkedlist_int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> li = new LinkedList<int>();
            li.AddLast(1);
            li.AddLast(2);
            li.AddLast(3);  
            li.AddFirst(4);
            li.AddFirst(5);
            li.AddFirst(6);

            foreach(int i in li)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nAfter using node:");
            LinkedListNode<int> node = li.Find(6);
            li.AddAfter(node,12);

            foreach(int i in li)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
