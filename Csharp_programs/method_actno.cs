//3- create a method with 3 parameter actno, amount , and deposit or withdrawl 
//and then print the result


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_actno
{
    internal class Program
    {
        static int account(int actno,int amount)
        {
            int result=0;
            int balance = 1000;
            
            int dep = balance + amount;
            int withdrawl=balance - amount;

            Console.WriteLine("Balance Deposite: " + dep);
            Console.WriteLine("Balance Withdrawl: " + withdrawl);

            return result;
        }
        static void Main(string[] args)
        {
            int actno=0;
            int amount=0;
            Console.WriteLine("Enter act no: ");
            actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Amount: ");
            amount = Convert.ToInt32(Console.ReadLine());
            int result=account(actno,amount);
   
            Console.ReadKey();
        }
    }
}
