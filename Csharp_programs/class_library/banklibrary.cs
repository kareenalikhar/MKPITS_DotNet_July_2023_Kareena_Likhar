using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace banklibrary
{
    public abstract class bank
    {
        public int actno;
        public int balance = 1000;
        public abstract string deposit(int amt);
        public string withdrawl(int amt)
        {
            if (balance < amt)
            {
                return "Insufficient Amount in Account";
            }
            else
            {
                balance = balance - amt;
                return "Balance After withdrawl: " + balance;
            }
        }
        public string showbalance()
        {
            return "Account no: "+actno+"\n"+ "Balance amount is: " + balance;
        }
    }
    public class saving:bank
    {
        public override string deposit(int amt)
        {
            int interest = 300;
            balance = balance + amt + interest;
            return "Balance of saving account after deposit: " + balance;
        }
    }
    public class current : bank
    {
        public override string deposit(int amt)
        {
            balance = balance + amt ;
            return "Balance of current account after deposit: " + balance;
        }
    }
}
