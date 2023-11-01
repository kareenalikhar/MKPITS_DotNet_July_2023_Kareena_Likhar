using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties_bankaccount_transfer
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public int Balance { get; set; }

        public void display()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Account Holder Name: " + AccountHolderName);
            Console.WriteLine("Balance: " + Balance);
            Console.WriteLine("===================================");


        }
        public void transfer(BankAccount ba)
        {
            Balance=Balance+ba.Balance;
            ba.Balance = 0;
        }

        public void balance()
        {
            Console.WriteLine("The current balance for account no {0}: {1}",AccountNumber,Balance);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
                account1.AccountNumber= 1;
                account1.AccountHolderName = "Kareena";
                account1.Balance = 100;
                account1.display();

            BankAccount account2= new BankAccount();
                account2.AccountNumber= 2;
                account2.AccountHolderName = "Rohit";
                account2.Balance = 1000;
                account2.display();

            account1.transfer(account2);
            Console.WriteLine("Balance after Transaction: ");
            account1.balance();
            account2.balance();

            Console.ReadKey();

        }
    }
}
