using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_array_books
{
    class Books
    {
        string title;
        string author;
        int year;
        public void getdata(string title, string author, int year)
        {

            this.title = title;
            this.author = author;
            this.year = year;
        }
        public void displaydata()
        {
            
            Console.WriteLine("Book Title: " + title);
            Console.WriteLine("Book Author: " + author);
            Console.WriteLine("Book Publication year: " + year);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Books[] b1 = new Books[3];
            b1[0] = new Books();
            b1[1] = new Books();
            b1[2] = new Books();

            string aut=null;
            string tit=null;
            int pyear=0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter book title");
                tit = Console.ReadLine();
                Console.WriteLine("Enter book Author");
                aut = Console.ReadLine();
                Console.WriteLine("Enter Publication year title");
                pyear =Convert.ToInt32( Console.ReadLine());
                b1[i].getdata(tit, aut, pyear);
            }
            for (int i = 0; i < 3; i++)
            {
                b1[i].displaydata();
            }
            Console.ReadKey();
        }
    }
}
