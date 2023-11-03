using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_book
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public Book() 
        {
            bookid = 1;
            title = "Dotnet";
            author = "Sir";
            price = 65000;
        }

        public void display()
        {
            Console.WriteLine("Book id: " + bookid);
            Console.WriteLine("Book Title: " + title);
            Console.WriteLine("Book Author: " + author);
            Console.WriteLine("Book Price: " + price);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1= new Book();
            b1.display();
            Console.ReadKey();
        }
    }
}
