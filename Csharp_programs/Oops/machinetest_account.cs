using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machinetest_account
{
    class Bank
    {

        List<Customer> cust = new List<Customer>();
        public void AddCustomer(Customer customer)
        {
            cust.Add(customer);
        }

        public void DisplayCustomerDetails(string Custid)
        {
            Customer customer = cust.Find(c => c.custid == Custid);
            if (customer != null)
            {
                Console.WriteLine("Customer Id: " + Custid);
                Console.WriteLine("Account Details: ");

                foreach (Account account in customer.accounts)
                {
                    Console.WriteLine("Account id: " + account.accid );
                    Console.WriteLine("Balance: " + account.bal);
                }
                Console.WriteLine("Total Balance: " + customer.GetTotalBalance());
            }
            else
            {
                Console.WriteLine("Customer not found");
            }
        }
    }

    class Customer
    {
        public string custid {  get; set; }

        public List<Account> accounts = new List<Account>();

        public Customer(string Custid) 
        {
            custid = Custid;
        }
        public void Addaccount(Account account)
        {
            accounts.Add(account);
        }

        public decimal GetTotalBalance()
        {
            decimal totalBalance = 0;
            foreach(Account acc in accounts)
            {
                totalBalance = totalBalance + acc.bal;
            }
            return totalBalance;
        }

    }

    class Account
    {
        public string accid {  get; set; }
        public int bal {  get; set; }

        public Account(string accid, int bal)
        {
            this.accid = accid;
            this.bal = bal;
        }

        public void deposit(int amt)
        {
            bal=bal+amt;
        }
        public bool withdrawl(int amt)
        {
            if(amt<bal)
            {
                bal=bal-amt;
                return true;
            }
            else
            {
                Console.WriteLine("Insufficeint balance!!");
                return false;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            // Create customers and accounts
            Customer customer1 = new Customer("C1");
            Account account1 = new Account("A1", 1000);
            Account account2 = new Account("A2", 500);

            customer1.Addaccount(account1);
            customer1.Addaccount(account2);

            Customer customer2 = new Customer("C2");
            Account account3 = new Account("A3", 1500);

            customer2.Addaccount(account3);

            bank.AddCustomer(customer1);
            bank.AddCustomer(customer2);

            bank.DisplayCustomerDetails("C1");
            bank.DisplayCustomerDetails("C2");

            Console.WriteLine("______________________");
            account1.deposit(200);
            account2.withdrawl(300);
            account3.withdrawl(200);

            bank.DisplayCustomerDetails("C1");
            bank.DisplayCustomerDetails("C2");

            Console.ReadKey();

        }
    }
}
