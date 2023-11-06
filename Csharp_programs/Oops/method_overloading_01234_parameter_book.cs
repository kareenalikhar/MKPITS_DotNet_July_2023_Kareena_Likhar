using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading_01234_parameter_book
{
    internal class Program
    {
        class Book
        {
            int bookid;
            string title, author;
            int price;

            public void getdata()
            {
                bookid = 1;
                title = "Oracle";
                author = "James";
                price = 100;
            }

            public void getdata(int bookid)
            {
                this.bookid = bookid;
            }

            public void getdata(int bookid,string title)
            {
                this.bookid = bookid;
                this.title = title;                
            }

            public void getdata(int bookid, string title,string author)
            {
                this.bookid = bookid;
                this.title = title;
                this.author = author;
            }

            public void getdata(int bookid, string title, string author,int price)
            {
                this.bookid = bookid;
                this.title = title;
                this.author = author;
                this.price = price;
            }
            
            public void display()
            {
                Console.WriteLine("Book id: " + bookid);
                Console.WriteLine("Book title: " + title);
                Console.WriteLine("Book Author: " + author);
                Console.WriteLine("Book Price: " + price);
            }

        }
        static void Main(string[] args)
        {
            Book book = new Book();
            book.getdata();
            book.display();
            Console.WriteLine("-----------------book1 details ----------");
            Book book1 = new Book();
            book1.getdata(123,"Csharp");
            book1.display();
            Console.WriteLine("-----------------book2 details ----------");
            Book book2 = new Book();
            book2.getdata(123, "Csharp","unknown");
            book2.display();
            Console.WriteLine("-----------------book3 details ----------");
            Book book3 = new Book();
            book3.getdata(123, "Csharp", "unknown",2000);
            book3.display();

            Console.ReadKey();
        }   
    }
}
