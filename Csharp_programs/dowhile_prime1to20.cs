using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhile_primenoupto20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("prime no: 2");
            int num = 3, counter = 2, flag = 0;
            do
            {
                flag = 0;
                counter = 2;
                do
                {
                    if (num % counter == 0)
                    {
                        flag = 1;
                        break;
                    }
                    counter++;
                } while (counter < num);
                if (flag == 0)
                {
                    Console.WriteLine("prime no: " + num);

                }
                num++;
            } while (counter <= 20);
            Console.ReadKey();
        }
    }
}
