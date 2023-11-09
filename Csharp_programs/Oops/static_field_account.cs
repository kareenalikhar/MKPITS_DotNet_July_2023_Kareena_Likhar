using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_field_account
{
    public class Account
    {
        public int accno;
        public string name;
        public static float rateofinterest = 8.8f;
        public Account(int accno,string name) 
        { 
            this.accno = accno; 
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine(accno + "" + name + "" + rateofinterest);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(1, "Kareena");
            Account a2 = new Account(2, "Rohit");
            a1.display();
            a2.display();

            Console.ReadKey();
        }
    }
}
