using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_keyword_class_book
{
    class Book
    {
        public static int bookid;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.bookid = 1;
            Console.WriteLine("Book id: "+Book.bookid);

            Console.ReadKey();
        }
    }
}
