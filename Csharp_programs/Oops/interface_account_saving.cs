using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_account_saving
{
    interface account
    {
        string deposit(int actno,int amount);
    }
    class saving:account
    {
        public int actno;
        public int balance = 1000;
        public string deposit(int actno,int amount)
        {
            this.actno = actno;
            balance = balance + amount;
            return "Actno: " + actno + "Balance: " + balance;

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account no: ");
            int actno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount: ");
            int amt=Convert.ToInt32(Console.ReadLine());
            account a=new saving();
            string res=a.deposit(actno, amt);
            Console.WriteLine(res);

            Console.ReadKey();
            
        }
    }
}
