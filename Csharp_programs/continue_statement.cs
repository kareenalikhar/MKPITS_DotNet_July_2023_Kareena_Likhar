using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace continue_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=1;
            while(true)
            {
                Console.WriteLine(num);
                num++;
                if (num < 10)
                    continue;
                else
                    break;
                
            }
            Console.ReadKey();
        }
    }
}
