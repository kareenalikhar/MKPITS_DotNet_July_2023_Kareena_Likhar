using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphism_Account_current_saving
{
    class Account
    {
        public int actno;
        public int balance = 1000;
        public int interest = 500;
        public virtual void deposit(int actno,int amount)
        {
            Console.WriteLine("deposite method from class account");
        }
        public void showbalance()
        {
            Console.WriteLine("Balance: " + balance);
        }
    }
    class current:Account
    {
        public override void deposit(int actno, int amount)
        {
            this.actno=actno;
            balance =balance + amount;
            Console.WriteLine("Balnce successfully deposite on current account");
        }
    }
    class saving : Account
    {
        public override void deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount+interest;
            Console.WriteLine("Balnce successfully deposite on saving account");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Account no: ");
            int actno=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter amount: ");
            int amount=Convert.ToInt32(Console.ReadLine());

            Account a=new current();
            a.deposit(actno, amount);
            a.showbalance();

            Account a1= new saving();
            a1.deposit(actno, amount);
            a1.showbalance();

            Console.ReadKey();
        }
    }
}
