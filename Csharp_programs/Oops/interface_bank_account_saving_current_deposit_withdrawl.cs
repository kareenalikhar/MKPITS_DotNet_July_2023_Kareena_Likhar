using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_bank_account_saving_current_deposit_withdrawl
{
    interface bank
    {
        string deposit(int actno,int amount);
        string withdrawl(int actno, int amount);
        
    }
    class account
    {
        public int actno;
        public int balance=1000;
        public int interest = 500;
    }
    class current :account,bank
    {
        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Account no: " + actno + "\n" + "Balance: " + balance;
        }
        public string withdrawl(int actno, int amount)
        {
            this.actno = actno;
            balance = balance - amount;
            return "Account no: " + actno + "\n" + "Balance: " + balance;
        }

    }
    class saving : account, bank
    {
        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount+interest;
            return "Account no: " + actno + "\n" + "Balance: " + balance;
        }
        public string withdrawl(int actno, int amount)
        {
            this.actno = actno;
            balance = balance - amount;
            return "Account no: " + actno + "\n" + "Balance: " + balance;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Account no: ");
            int actno=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter amount: ");
            int amt = Convert.ToInt32(Console.ReadLine());

            bank b = null;

            Console.WriteLine("Enter current and saving: ");
            string banktype=Console.ReadLine();

            if(banktype=="current")
            {
                b = new current(); 
            }
            else if (banktype == "saving")
            {
                b = new saving();
            }

            Console.WriteLine("Enter deposit and withdrawl: ");
            string tt = Console.ReadLine();
            string res = null;

            if (tt == "deposit")
                 res=b.deposit(actno, amt);
            
            else if (tt == "withdrawl")          
                 res = b.withdrawl(actno, amt);
            
            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
