//17. Write a C# Sharp program to calculate profit and loss on a transaction.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_profitloss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sp, cp,result,result1;
            Console.WriteLine("Selling Price: ");
            sp=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cost Price: ");
            cp = Convert.ToInt32(Console.ReadLine());
            result = sp - cp;
            result1 = cp - sp;
            if(sp>cp)
            {
                Console.WriteLine("Your Profit amount : " + result);
            }
            else
            {
                Console.WriteLine("Your Loss amount : " + result1);
            }
            Console.ReadKey();
        }
    }
}
