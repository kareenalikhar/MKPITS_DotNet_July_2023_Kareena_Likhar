using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class_account
{
    abstract class Account
    {
        public abstract void deposit();
    }

    class Saving: Account
    {
        public override void deposit()
        {
            Console.WriteLine("Hello from class saving method deposit");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Account act=new Saving();
            act.deposit();

            Console.ReadLine();
        }
    }
}
