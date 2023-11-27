using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generic_collection_dictionary_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> li=new Dictionary<string, string>();
            li.Add("in", "India");
            li.Add("ge", "Germany");
            li.Add("us", "United State");

            Console.WriteLine(li["in"]);
            Console.WriteLine(li["ge"]);
            Console.WriteLine(li["us"]);

            Console.WriteLine("List has {0} items: ",li.Count);

            Console.WriteLine("Keys of dictionary: ");

            List<string> keys= new List<string>(li.Keys);

            foreach(string key in keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("Values of dictionary: ");
            List<string> value=new List<string>(li.Values);
            foreach(string val in value)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine(" Keys and values of dictionary: ");
foreach(KeyValuePair<string,string> kvp in li)
            {
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
            }
            Console.ReadKey();
        }
    }
}
