using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_account_saving_current_switch
{
    interface Account
    {
        string deposit(int actno, int amount);
    }
    class current:Account
    {
        public int actno;
        public int balance = 1000;
        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = amount + balance;
            return "Acc no: " + actno +"\n"+ "Balance: " + balance;
        }
    }
    class saving : Account
    {
        public int actno;
        public int balance = 1000;
        public int interest = 500;
        public string deposit(int actno, int amount)
        {
            this.actno = actno;
            balance = amount + balance+interest;

            return "Acc no: " + actno + "\n" + "Balance: " + balance;
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

            Account act = null;
            Console.WriteLine("Enter current or saving: ");
            string tt=Console.ReadLine();

            switch(tt) 
            {
                case "saving":
                    act = new saving();
                    break;

                case "current":
                    act = new current();
                    break;
                    
            }
            
            string res=act.deposit(actno, amt);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
