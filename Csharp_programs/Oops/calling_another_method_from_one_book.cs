using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_another_method_from_one_book
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public void getdata()
        {
            bookid = 123;
            title = "Charli";
            author = "James";
            price = 2000;
        }
        public void getdata(int bookid)
        {
            this.bookid = bookid;
            getdata(bookid,"html");
        }
        public void getdata(int bookid,string title)
        {
            this.bookid = bookid;
            this.title = title;
            getdata(bookid, title,"Charle");
        }

        public void getdata(int bookid, string title,string author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            getdata(bookid, title, author,234);
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
            Console.WriteLine("Book price: " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1= new Book();
            b1.getdata(899);
            b1.display();
            Console.WriteLine("-----------------book1 details ----------");


            Console.ReadLine();


        }
    }
}
