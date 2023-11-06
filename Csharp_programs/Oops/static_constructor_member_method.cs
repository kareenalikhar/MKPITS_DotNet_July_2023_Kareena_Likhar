using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor_member_method
{
    class book
    {
        static string title;
        static book()
        {
            Console.WriteLine("Static constructor called: ");
            title = "mkpits";
        }
        public static void display()
        {
            Console.WriteLine("Title: " + title);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book.display();

            Console.ReadKey();
        }
    }
}
