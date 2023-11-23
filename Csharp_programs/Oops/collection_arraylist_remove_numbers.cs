using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_arraylist_remove_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar=new ArrayList();
            ar.Add(1);
            ar.Add(2);
            ar.Add(3);

            foreach(int i in ar)
            {
                Console.WriteLine("numbers: " + i );
            }

            Console.WriteLine("\nAfter removing: ");
            ar.Remove(2);
            foreach (int i in ar)
            {
                Console.WriteLine("numbers: " + i);
            }
            Console.ReadKey();
        }
    }
}
