using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphism_account_current_user
{
    class Account
    {
        public int actno;
        public int balance = 1000;

        public virtual void deposit(int actno, int amount)
        {
            Console.Write("deposite method of class account");
        }
        public void showbalance()
        {
            Console.WriteLine( "Balance: " + balance);
        }
    }
    class Current: Account
    {
        public override void deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            Console.WriteLine( "Amount deposite in current account successfully");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Account no: ");
            int actno=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Amount: ");
            int amt=Convert.ToInt32(Console.ReadLine());

            Account a=new Current();
            a.deposit(actno, amt);
            a.showbalance();

            Console.ReadKey();
            
        }
    }
}
