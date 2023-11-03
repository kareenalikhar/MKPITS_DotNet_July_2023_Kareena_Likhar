using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_default_parameter_book
{
    class book
    {
        int id;
        string title;
        string author;
        int price;

        public book()
        {
            id = 123;
            title = "Succesfull life";
            author = "Sandeep Maheshwari";
            price = 500;
        }

        public book(int id, string title, string author, int price)
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public void display()
        {
            Console.WriteLine("Book id: "+id);
            Console.WriteLine("Book title: "+title);
            Console.WriteLine("Book author: "+author);
            Console.WriteLine("Book price: "+price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            book b = new book();//this will call constructor automatically
            b.display();
            Console.WriteLine("-----------------book details ----------");
            book b1 = new book(111, "csharp", "martin", 2000); // this will call parameterized constructor
            b1.display();
            Console.WriteLine("-----------------book1 details ----------");
            Console.WriteLine("enter bookid");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter title");
            String title = Console.ReadLine();
            Console.WriteLine("enter author");
            String author = Console.ReadLine();
            Console.WriteLine("enter price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------book2 details ----------");
            book b2 = new book(id, title, author, price);
            b2.display();

            Console.ReadLine();

        }
    }
}
