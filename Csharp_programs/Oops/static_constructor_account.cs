using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructor_account
{
    public class account
    {
        public int accno;
        public string name;
        public static float rateofinterest;
        public account(int accno,string name) 
        {
            this.accno = accno;
            this.name = name;

        }
        static account()
        {
            Console.WriteLine("Call from account");
            rateofinterest = 9.5f;
        }
        public void display()
        {
            Console.WriteLine(accno+" "+name+" "+rateofinterest);
        }
}
    internal class Program
    {
        static void Main(string[] args)
        {
            account a1=new account(102,"kareena");
            account a2 = new account(103, "rohit");
            a1.display();
            a2.display();
            Console.ReadKey();
        }
    }
}
