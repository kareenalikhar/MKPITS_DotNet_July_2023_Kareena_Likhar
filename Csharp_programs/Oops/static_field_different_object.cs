using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_field_different_object
{
    class book
    {
        static string title;
        static book()
        {
            Console.WriteLine("Static Constructor called: ");
            title = "mkpits";
        }
        public void display()
        {
            Console.WriteLine("Title: "+title);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book1.display();
            book book2 = new book();
            book2.display();

            Console.ReadKey();
        }
    }
}
