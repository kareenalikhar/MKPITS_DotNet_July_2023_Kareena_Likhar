using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_constructor_book
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;

        public Book() 
        {
            bookid = 123;
            title = "abcd";
            author = "someone";
            price = 100;
        }
        public Book(Book b2)
        {
            bookid=b2.bookid;
            title=b2.title;
            author=b2.author;
            price=b2.price;
        }
        public void display()
        {
            Console.WriteLine("Book id: " + bookid);
            Console.WriteLine("Book title: " + title);
            Console.WriteLine("Book Author: " + author);
            Console.WriteLine("Book Price: " + price);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine("Book details: ");
            book.display();
            Book book1 = new Book(book);
            Console.WriteLine("Book1 details: ");
            book1.display();
            Console.ReadKey();
        }
    }
}
