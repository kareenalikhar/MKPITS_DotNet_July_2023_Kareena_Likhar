using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile_table_vertically
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int flag;
            Console.WriteLine("Enter Limit: ");
            flag = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            int counter1 = 1;
            do
            {
                counter1 = 1;
                do
                {
                    Console.Write("{0} * {1} = {2} ", counter1, counter, (counter1 * counter));
                    Console.Write("\t");
                    counter1++;
                } while (counter1 <= flag);
                counter++;
                Console.WriteLine();
            } while (counter <= 10);
            Console.ReadKey();
        }
    }
}


