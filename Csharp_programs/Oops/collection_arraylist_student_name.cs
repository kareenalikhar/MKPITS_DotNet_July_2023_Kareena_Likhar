using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_arraylist_studentname
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar=new ArrayList();
            ar.Add("Kareena");
            ar.Add("Pooja");
            ar.Add("Chandrima");
            ar.Add("Akash");

            foreach(object obj in ar)
            {
                Console.WriteLine("Name: "+obj);
            }
            Console.ReadKey();
        }
    }
}
