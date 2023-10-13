//10. Write a C# Sharp program to determine the eligibility for admission to a professional course based on the following criteria:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_addmissioneligible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maths, phy, chem,total;
            Console.WriteLine("marks obtained in Mathematics : ");
            maths=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("marks obtained in Physics  : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("marks obtained in Chemistry  : ");
            chem = Convert.ToInt32(Console.ReadLine());
            total= maths+ phy+ chem;
            Console.WriteLine("Total: " + total);
            if (maths >= 65 && phy >= 55 && chem >= 50 && total>=140)
            {
                Console.WriteLine("The candidate is eligible for admission.");
            }
            else
            {
                Console.WriteLine("The candidate is not eligible for admission.");
            }
            Console.ReadKey();

        }
    }
}
