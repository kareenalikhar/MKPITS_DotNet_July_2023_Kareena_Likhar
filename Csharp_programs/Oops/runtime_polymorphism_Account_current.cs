using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphism_Account_current
{
    class Account
    {
        public int actno;
        public int balance = 1000;

        public virtual String deposit(int actno,int amount)
        {
            return "Deposite method of account class";
        }

        public String showbalance()
        {
            return "Balance: " + balance;
        }
    }
    class Current:Account
    {
        public override String deposit(int actno, int amount) 
        {
            this.actno=actno;
            balance = balance + amount;
            return "Amount deposite successfully in current class";
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account a=new Current();
            string res=a.deposit(123, 100);
            string res2 = a.showbalance();
            Console.WriteLine(res);
            Console.WriteLine(res2);
            Console.ReadKey();

        }
    }
}
