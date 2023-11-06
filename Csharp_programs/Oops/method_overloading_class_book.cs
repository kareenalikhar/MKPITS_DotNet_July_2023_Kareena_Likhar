using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading_class_book
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public void getdata()
        {
            bookid = 123;
            title = "Oracle";
            author = "James";
            price = 200;
        }
        public void getdata(int bookid,string title,string author,int price) 
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Book Id: " + bookid);
            Console.WriteLine("Book Title: " + title);
            Console.WriteLine("Book Author: " + author);
            Console.WriteLine("Book Price: " + price);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.getdata();
            book.display();
            Console.WriteLine("-------Book 1 details--------");
            Book book1 = new Book();
            book1.getdata(111,"csharp","martin",2000);
            book1.display();
            Console.WriteLine("Enter bookid: ");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Title: ");
            string title=Console.ReadLine();
            Console.WriteLine("Enter Author: ");
            string author=Console.ReadLine();
            Console.WriteLine("Enter Price: ");
            int price=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------book2 details-----------");
            Book book2 = new Book();
            book2.getdata(id,title,author,price);
            book2.display();
            Console.ReadKey();
        }
    }
}
