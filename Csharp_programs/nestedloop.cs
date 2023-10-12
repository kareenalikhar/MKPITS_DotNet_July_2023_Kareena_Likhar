using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nestedloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, num, width;
            Console.WriteLine("Enter No : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter width : ");
            width = Convert.ToInt32(Console.ReadLine());


            for (i = num; i >= 1; i--) ;
            {
                for (j = 1; j <= i; j++) ;
                {
                    Console.WriteLine(width);


                }
                Console.WriteLine();
                Console.ReadKey();

            }

        }
    }
}