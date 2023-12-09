using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace machine_test_bank
{
    class Bank
    {
        List<Customer> cust;

        public Bank() 
        {
            cust = new List<Customer>();
            
        }
        public void addcustomer(Customer customer)
        {
            cust.Add(customer);
        }
        public void displaycustomer()
        {
            Console.WriteLine(cust);
        }
        
    }
    class Customer
    {
        public string name;
        
        List<Account> accounts;
        public Customer(string name)
        {
            accounts = new List<Account>();
            this.name = name;
        }
        public void addaccount(Account account)
        {
            accounts.Add(account);
        }
        
    }

    class Account
    {
        public int accid;
        public int bal = 1000;
        public int amt;

        public Account(int accid,int amt)
        {
            this.accid = accid;
            this.amt = amt;
        }
        public void deposit()
        {
            bal=bal+amt;
        }
        public void withdraw()
        {
            bal = bal - amt;
        }
        public void Display()
        {

            Console.WriteLine("Account Details:");

           
               // Console.WriteLine("Name: {0}", account.name);
                Console.WriteLine("Account No: {0}", accid);
                Console.WriteLine("Balance: {0}", bal);
                Console.WriteLine("__________________________");
            


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            while (true)
            {

                Console.WriteLine("Enter Name of customer: ");
                string cust1 = Console.ReadLine();
                Console.WriteLine("Enter Account no: ");
                int accno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Amount: ");
                int amt = Convert.ToInt32(Console.ReadLine());
                Customer c1 = new Customer(cust1);
                Account a1 = new Account(accno, amt);
                Console.WriteLine("Do you want to deposit or withdrawl");
                string choice = Console.ReadLine();
                if (choice == "deposit")
                {
                    a1.deposit();
                    a1.Display();

                }
                else if (choice == "withdrawl")
                {
                    a1.withdraw();
                    a1.Display();
                }

            }

            Console.ReadKey();

        }
    }
}
