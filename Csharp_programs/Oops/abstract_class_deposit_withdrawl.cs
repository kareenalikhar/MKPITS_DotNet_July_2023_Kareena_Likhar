using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_deposit_withdrawl
{
    abstract class Account
    {
        public int balance = 1000;
        public abstract void deposit(int amount);
        public abstract void withdrawl(int amount);

        public void showbalance()
        {
            Console.WriteLine("Account Balance: " + balance);
        }
    }
    class current:Account
    {
        public override void deposit(int amount)
        {
            balance=balance+amount;
        }
        public override void withdrawl(int amount)
        {
            balance = balance - amount;
        }
    }
    class saving : Account
    {
        public override void deposit(int amount)
        {
            int interest = 500;
            balance = balance + amount+interest;
        }
        public override void withdrawl(int amount)
        {
            balance = balance - amount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account type saving or current: ");
            string acttype=Console.ReadLine();

            Account act = null;
            if (acttype == "current")
            {
                act = new current();
            }
            else if(acttype =="saving")
            {
                act = new saving();
            }

            Console.WriteLine("Enter deposit or withdrawl: ");
            string tt=Console.ReadLine();

            if(tt =="deposit")
            {
                act.deposit(amount);
            }
            else if(tt =="withdrawl")
            {
                act.withdrawl(amount);
            }
            act.showbalance();

            Console.ReadLine();
        }
    }
}
