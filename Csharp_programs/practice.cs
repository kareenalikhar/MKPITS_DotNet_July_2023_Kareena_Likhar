using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cnt1, cnt2;
            for (cnt1 = 1, cnt2 = 1; cnt1 <= 5 && cnt2 <= 10; cnt2++)
            {
                Console.WriteLine("{0}*{1}={2}", cnt1, cnt2, (cnt1 * cnt2));

                if (cnt2 == 10)
                {
                    cnt1++;
                    cnt2 = 1;
                }
            }
            

            Console.ReadKey();
        }
    }
}
