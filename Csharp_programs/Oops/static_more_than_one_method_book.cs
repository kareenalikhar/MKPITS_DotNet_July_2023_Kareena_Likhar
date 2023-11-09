using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_more_than_one_method_book
{
    class Book
    {
        public static int bookid;
        public static void display()
        {
            Console.WriteLine("Hello from method display");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.bookid = 123;
            Book.display();
            Console.WriteLine("Book id: "+Book.bookid);
            Program p1 = new Program();
            p1.Main();
            Console.ReadKey();
        }

        void Main()
        {
            Console.WriteLine("Hello from method main");
        }

    }
}
