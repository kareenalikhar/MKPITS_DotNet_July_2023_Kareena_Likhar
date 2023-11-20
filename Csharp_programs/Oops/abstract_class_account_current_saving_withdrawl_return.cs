using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_account_deposit_withdrawl_return
{
    abstract class Account
    {
        public int actno;
        public int balance = 1000;
        public abstract string deposit(int actno, int amount);

        public string showbalance()
        {
            return "Account no : " + actno +"\n" + "Balance: " +balance ;

        }
    }
    class Current : Account
    {
        public override string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance += amount;
            return "Balance successfully deposited in current account";
        }
    }
    class Saving : Account
    {
        public override string deposit(int actno, int amount)
        {
            int interest = 500;
            this.actno = actno;
            balance = balance + amount + interest;
            return "Balance successfully deposited in saving account with interest";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account no: ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Account type saving or current: ");
            string acttype = Console.ReadLine();

            Account act = null;

            if (acttype == "current")
            {
                act = new Current();
            }
            else if (acttype == "saving")
            {
                act = new Saving();
            }
            string res = act.deposit(actno, amount);
            Console.WriteLine(res);
            string res1 = act.showbalance();
            Console.WriteLine(res1);

            Console.ReadKey();
        }
    }
}
