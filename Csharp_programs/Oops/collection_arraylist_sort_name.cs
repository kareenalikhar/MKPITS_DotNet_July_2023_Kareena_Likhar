using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_arraylist_sort_name
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar=new ArrayList();
            ar.Add("Kareena");
            ar.Add("Chandrima");
            ar.Add("Pooja");
            ar.Add("Akash");

            Console.WriteLine("Name after sorting: ");
            ar.Sort();
            foreach(object o in ar)
            {
                Console.WriteLine("Name: "+o);
            }
            Console.ReadKey();
        }
    }
}
