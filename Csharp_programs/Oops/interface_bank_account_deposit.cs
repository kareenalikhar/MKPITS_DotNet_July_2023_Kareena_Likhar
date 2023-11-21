using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_bank_account_deposit
{
    interface bank
    {
        string deposit(int actno, int amount);
    }
    class acount
    {
        public int actno;
        public int balance=1000;
    }
    class current:acount,bank
    {
        public string deposit(int actno,int amount)
        {
            balance = amount + balance;
            return "Account no: " + actno + "\n" + "Balance: " + balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter actno: ");
            int actno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount: ");
            int amt=Convert.ToInt32(Console.ReadLine());

            bank b = new current();
            string res=b.deposit(actno, amt);
            Console.WriteLine(res);
            Console.ReadKey();


        }
    }
}
