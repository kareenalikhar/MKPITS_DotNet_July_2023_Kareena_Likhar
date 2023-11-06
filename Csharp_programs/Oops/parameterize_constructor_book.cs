using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parameterize_constructor_book
{
    class Book
    {
        int id;
        string title;
        string author;
        int price;

        public Book() 
        {
            id = 123;
            title = "Csharp";
            author = "Sir";
            price = 500;
        }

        public Book(int id, string title, string author, int price)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public void display()
        {
            Console.WriteLine("Book Id: " + id);
            Console.WriteLine("Book Title: " + title);
            Console.WriteLine("Book Author: " + author);
            Console.WriteLine("Book Price: " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.display();

            Book book2= new Book(123,"Java","Sir",5000);
            book2.display();
            Console.ReadKey();
        }
    }
}
