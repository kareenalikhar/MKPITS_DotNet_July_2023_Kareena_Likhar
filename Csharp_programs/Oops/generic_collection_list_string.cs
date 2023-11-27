using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collection_list_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> li=new List<string>();
            li.Add("Csharp");
            li.Add("Java");
            li.Add("Php");
            li.Add("Sql");

            Console.WriteLine(li.Contains("Java"));

            Console.WriteLine(li[1]);
            Console.WriteLine(li[2]);
            Console.WriteLine(li[3]);
            Console.WriteLine(li[0]);

            Console.WriteLine("\nAfter Removing:");
            li.Remove("Php");
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\nAfter Inserting: ");

            li.Insert(1, "Oracle");

            foreach(string s in li)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\nAfter Sorting: ");

            li.Sort();
            foreach (string s in li)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}
