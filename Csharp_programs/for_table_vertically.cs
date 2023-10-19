//7. Write a program in C# Sharp to display the multiplication table vertically from 1 to n.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_table_vertically
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag;
            Console.WriteLine("Enter Limit: ");
            flag=Convert.ToInt32(Console.ReadLine());
            int counter, cnt1;
            for(counter=1;counter<=10;counter++)
            {
                cnt1=1;
                for(cnt1=1;cnt1<=flag;cnt1++)
                {
                    Console.Write("{0}*{1}={2}",cnt1,counter,(cnt1*counter));
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
