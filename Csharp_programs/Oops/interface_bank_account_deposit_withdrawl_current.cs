using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_bank_account_deposit_withdrawl_current
{
    interface bank
    {
        string deposit(int actno, int amount);
        string withdrawl(int actno, int amount);

    }
    class account
    {
        public int actno;
        public int balance=1000;

        public void showbalance()
        {
            Console.WriteLine("Balance: " + balance);
        }
    }
    class current:account,bank
    {
        public string deposit(int actno, int amount)
        {
            balance += amount;
            return "Account no: " + actno + "\n" + "Balance: " + balance;
        }

        public string withdrawl(int actno, int amount)
        {
            balance -= amount;
            return "Account no: " + actno + "\n" + "Balance: " + balance;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter acct no: ");
            int actno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount: ");
            int amt=Convert.ToInt32(Console.ReadLine());

            current b=new current();
            string res=b.deposit(actno, amt);
            Console.WriteLine(res);

            string res1=b.withdrawl(actno, amt);
            Console.WriteLine(res1);
            b.showbalance();

            Console.ReadLine();



            
        }
    }
}
