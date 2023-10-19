/* 1 1 1
 * 2 2 2
 * 3 3 3*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedfor_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int innercounter, outercounter;
            for(innercounter = 1;innercounter<=3;innercounter++)
            {
                for(outercounter = 1;outercounter<=3;outercounter++)
                {
                    Console.Write(outercounter + "\t");

                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
