using System;

namespace LibraryBook
{
    class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of LibraryBook objects
            LibraryBook[] libraryBooks = new LibraryBook[3];
            libraryBooks[0] = new LibraryBook { Title = "Book1", Author = "Author1", IsAvailable = true };
            libraryBooks[1] = new LibraryBook { Title = "Book2", Author = "Author2", IsAvailable = false };
            libraryBooks[2] = new LibraryBook { Title = "Book3", Author = "Author3", IsAvailable = true };

            Console.WriteLine("Available Books in the Library:");
            for (int i = 0; i < libraryBooks.Length; i++)
            {
                if (libraryBooks[i].IsAvailable)
                {
                    Console.WriteLine("Title: " + libraryBooks[i].Title);
                    Console.WriteLine("Author: " + libraryBooks[i].Author);
                    Console.WriteLine("-------------------------");
                }
            }

            Console.ReadKey();
        }
    }
}
