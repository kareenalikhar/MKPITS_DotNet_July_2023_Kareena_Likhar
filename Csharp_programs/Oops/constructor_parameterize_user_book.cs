using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_parametrize_user_book
{
    class Book
    {
        int id;
        string title;
        string author;
        int price;

        public Book(int id, string title, string author, int price)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public void display()
        {
            Console.WriteLine("Book id: " + id);
            Console.WriteLine("Book title: " + title);
            Console.WriteLine("Book Author: " + author);
            Console.WriteLine("Book Price: " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Book id: ");
            int i1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book title: ");
            string title=Console.ReadLine();
            Console.WriteLine("Enter Book author: ");
            string author=Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            int price=Convert.ToInt32(Console.ReadLine());

            Book b2=new Book(i1, title, author, price);
            b2.display();
            Console.ReadKey();

        }
    }
}
