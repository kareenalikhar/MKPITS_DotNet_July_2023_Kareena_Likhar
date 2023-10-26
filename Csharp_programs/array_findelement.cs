using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_findelement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            int flag = 0;
            int usern = 0;
            Console.WriteLine("Enter number to be serched: ");
            usern=Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<num.Length; i++)
            {
                if (num[i] == usern)
                {
                    flag = 1;
                    break;
                }
            }
            if(flag==1)
            {
                Console.WriteLine("{0} num {1} is found in an array", usern);
            }
            else
            {
                Console.WriteLine("num is not found in an array");
            }
            Console.ReadKey();
        }
    }
}
