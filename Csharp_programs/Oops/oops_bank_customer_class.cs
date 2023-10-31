using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_bank_customer_class
{
    class Bank
    {
        string name;
        int accno;
        int amt;
        int bal = 1000;
        int withdrwal;
        int deposite;
        public void getdata(string name,int accno,int amt )
        {
            this.name = name;
            this.accno = accno;
            this.amt= amt;
            deposite = bal + amt;
            withdrwal = bal - amt;
        }
        public void displaydata()
        {
            Console.WriteLine("withdrwal: "+withdrwal);
            Console.WriteLine("deposite: " + deposite);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b1= new Bank();
            Console.WriteLine("Enter Name,account no: ");
            string nc=Console.ReadLine();
            int accno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter balance: ");
            int amt = Convert.ToInt32(Console.ReadLine());
            b1.getdata(nc, accno, amt );
            b1.displaydata();

            Console.ReadKey();




        }
    }
}
