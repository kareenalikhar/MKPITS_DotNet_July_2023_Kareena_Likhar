using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginpage
{
    class Program
    {
        static void Main(string[] args)
        {
            string uid;
            string pass;
            Console.WriteLine("Enter User id :");
            uid = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Password :");
            pass = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Unsuccesfull");
            Console.WriteLine("Unsuccesfull");
            Console.WriteLine("Unsuccesfull");
            Console.WriteLine("Rejected");

            Console.ReadKey();
        }
    }
}