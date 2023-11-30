using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling_invalidcastexception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb=new StringBuilder();
            sb.Append("Kareena");
            sb.Append("Rohit");
            Console.WriteLine(sb.ToString());
            object obj = sb;
            Console.WriteLine(obj.ToString());
            try
            {
                System.IO.StreamReader sr = (System.IO.StreamReader)obj;
            }
            catch(InvalidCastException ee)
            {
                Console.WriteLine(ee.ToString());
            }
            Console.WriteLine("Bye");
            Console.ReadLine();
        }
    }
}
