using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_arraylist_name_insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar=new ArrayList();
            ar.Add("Kareena");
            ar.Add("Pooja");
            ar.Add("Akash");
            ar.Add("Chandrima");

            foreach(object obj in ar)
            {
                Console.WriteLine("Name: "+obj);
            }

            Console.WriteLine("after inserting");

            ar.Insert(2,"Sarang");
            foreach(object obj in ar)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();


        }
    }
}
