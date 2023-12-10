using System;
using System.Collections.Generic;

class Author
{
    public string AuthorName { get; set; }

    public Author(string authorName)
    {
        AuthorName = authorName;
    }
}

class Book
{
    public string Title { get; set; }
    public int ISBN { get; set; }
    

    public Book(string title, int isbn)
    {
        Title = title;
        ISBN = isbn;
        
    }

    public void display()
    {
        
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Isbn: " + ISBN);
    }
}

class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }


    public void DisplayBooks()
    {
        Console.WriteLine("List of Books in the Library:");
        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }
}

class Program
{
    static void Main()
    {

        while (true)
        {
            Library l=new Library();
            l.DisplayBooks();

            Console.WriteLine("Enter Title: ");
            string title=Console.ReadLine();
            Console.WriteLine("Enter isbn: ");
            int isbn=Convert.ToInt32(Console.ReadLine());

            Book b = new Book(title,isbn);
            b.display();
        }
       
        Console.ReadKey();
    }
}
