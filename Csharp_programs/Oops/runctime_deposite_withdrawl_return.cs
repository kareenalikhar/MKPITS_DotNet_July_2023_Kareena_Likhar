using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runctime_deposite_withdrawl_return
{
    class Account
    {
        public int actno;
        public int balance = 1000;

        public virtual string deposit(int actno, int amount)
        {
            return "Deposite from class account";
        }
        public virtual string withdrawl(int actno, int amount)
        {
            return "Withdrawl from class account";
        }

        public string dshowbalance()
        {
            return "Deposite Balance: " + balance + "\n";
        }
        public string wshowbalance()
        {
            return "Withdrawl Balance: " + balance;
        }

    }
    class current : Account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Deposite successfully in current account";
        }
        public override string withdrawl(int actno, int amount)
        {
            balance = 1000;
            this.actno = actno;
            balance = balance - amount;
            if (amount > balance)
            {
                return "Insufficient balance for withdrawl from current account";
            }
            else
            {
                return "Withdrawl successfully in current account";
            }
        }
    }
    class saving : Account
    {
        public override string deposit(int actno, int amount)
        {
            int interest = 500;
            this.actno = actno;
            balance = balance + amount + interest;
            return "Deposite successfully in saving account";
        }
        public override string withdrawl(int actno, int amount)
        {
            balance = 1000;
            this.actno = actno;
            balance = (balance - amount);
            if (amount > balance)
            {
                return "Insufficient balance for withdrawl from saving account";
            }
            else
            {
                return "Withdrawl successfully in saving account";
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
                string res=act.deposit(actno, amt);
                string res1=act.dshowbalance();
                Console.WriteLine(res);
                Console.WriteLine(res1);
            }
            else if (choice == "withdrawl")
            {

                string res2=act.withdrawl(actno, amt);
                string res3=act.wshowbalance();
                Console.WriteLine(res2);
                Console.WriteLine(res3);
            }

            Console.ReadKey();



        }
    }
}
