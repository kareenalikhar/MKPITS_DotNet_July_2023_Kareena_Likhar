using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphism_Account_deposit_withdrawl
{
    class Account
    {
        public int actno;
        public int balance = 1000;

        public virtual void deposit(int actno, int amount)
        {
            Console.WriteLine("Deposite from class account");
        }
        public virtual void withdrawl(int actno, int amount)
        {
            Console.WriteLine("Withdrawl from class account");
        }

        public void dshowbalance()
        {
            Console.WriteLine("Deposite Balance: " + balance+"\n");
        }
        public void wshowbalance()
        {
            Console.WriteLine("Withdrawl Balance: " + balance);
        }

    }
    class current : Account
    {
        public override void deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            Console.WriteLine("Deposite successfully in current account");
        }
        public override void withdrawl(int actno, int amount)
        {
            balance = 1000;
            this.actno = actno;
            balance = balance - amount;
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance for withdrawl from current account");
            }
            else
            {
                Console.WriteLine("Withdrawl successfully in current account");
            }
        }
    }
    class saving : Account
    {
        public override void deposit(int actno, int amount)
        {
            int interest = 500;
            this.actno = actno;
            balance = balance + amount + interest;
            Console.WriteLine("Deposite successfully in saving account");
        }
        public override void withdrawl(int actno, int amount)
        {
            balance = 1000;
            this.actno = actno;
            balance = (balance - amount);
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance for withdrawl from saving account");
            }
            else
            {
                Console.WriteLine("Withdrawl successfully in saving account");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Account no: ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount: ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter saving or current account: ");
            string acttype = Console.ReadLine();
            
            
            Account act = null;
            if (acttype == "saving")
            {
                act = new saving();
            }
            else if (acttype == "current")
            {
                act = new current();
            }
            Console.Write("Do you want to deposite or withdrwal amount:");
            string choice = Console.ReadLine();
            if (choice == "deposite")
            {
                act.deposit(actno, amt);
                act.dshowbalance();
            }
            else if (choice == "withdrawl")
            {

                act.withdrawl(actno, amt);
                act.wshowbalance();
            }

            Console.ReadKey();



        }
    }
}
