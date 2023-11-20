using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_current_saving_act
{
    abstract class Account
    {
        public int actno;
        public int balance = 1000;
        public abstract void deposit(int amount);

        public void showbalance(int amount)
        {
            Console.WriteLine("Account no: " + actno);
            Console.WriteLine("Balance: " + balance);
        }

    }
    class current:Account 
    {
        public override void deposit(int amount)
        {
            balance+= amount;         
        }
    }
    class saving:Account
    {
        public override void deposit(int amount)
        {
            int interest = 500;
            balance=balance + amount+interest;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account no: ");
            int actno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount: ");
            int amt=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter account type saving or current: ");
            string acttype=Console.ReadLine();

            Account act = null;

            if(acttype =="saving")
            {
                act =new saving();
            }
            else if(acttype == "current")
            {
                act=new current();
            }

            act.actno = actno;
            act.deposit(amt);
            act.showbalance(amt);

            Console.ReadLine();
        }
    }
}
