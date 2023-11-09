using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_field_counting_object
{
    public class Account
    {
        public int accno;
        public string name;
        public static int count = 0;

        public Account(int accno,string name) 
        {
            this.accno = accno;
            this.name = name;
            count++;
        }

        public void display()
        {
            Console.WriteLine("Account no: " + accno);
            Console.WriteLine("Name : " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(123,"Kareena");
            Account a2 = new Account(12, "Rohit");
            Account a3 = new Account(1, "Ruchika");
            a1.display();
            a2.display();
            a3.display();
            Console.WriteLine("Counter: "+Account.count);
            Console.ReadKey();
        }
    }
}
