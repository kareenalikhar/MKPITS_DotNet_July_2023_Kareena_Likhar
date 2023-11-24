using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_hashtable_key_value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht= new Hashtable();
            ht.Add("1", "Kareena");
            ht.Add("2", "Rohit");
            ht.Add("3", "Akash");
            ht.Add("4", "Pooja");
            ht.Add("5", "Chandrima");

            if (ht.ContainsValue("Akash"))
            {
                Console.WriteLine("Already exits");
            }
            else
            {
                ht.Add("6", "Yashika");
            }
            ICollection key= ht.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(k + " : " + ht[k]);
            }

            Console.ReadKey();
        }
    }
}
