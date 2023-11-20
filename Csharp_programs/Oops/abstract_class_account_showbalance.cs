using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_account_showbalance
{
    abstract class Account
    {
        public abstract void deposit();

        public void showbalance()
        {
            Console.WriteLine("Show balance: ");
        }
    }
    class Deposit:Account
    {
        public override void deposit()
        {
            Console.WriteLine("Hello from class deposit");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account d=new Deposit();
            d.deposit();
            d.showbalance();

            Console.ReadLine();

        }
    }
}
