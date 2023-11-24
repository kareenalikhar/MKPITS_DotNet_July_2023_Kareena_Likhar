using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections;

namespace collection_sortedlist_key_values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add("1", "Kareena");
            sl.Add("2", "Pooja");
            sl.Add("3", "Chandu");
            sl.Add("4", "Akash");
            sl.Add("5", "Yashika");

            if(sl.ContainsKey("8"))
            {
                Console.WriteLine("already exits");
            }
            else
            {
                sl.Add("8", "Yashit");
            }
            ICollection key=sl.Keys;
            foreach(object s in key)
            {
                Console.WriteLine(s + " : " + sl[s]);
            }
            Console.ReadKey();
        }
    }
}
