using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace total_per_grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, total;
            float per;
            string grade;
            Console.Write("Enter sub1 marks: ");
            sub1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter sub2 marks: ");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter sub3 marks: ");
            sub3 = Convert.ToInt32(Console.ReadLine());
            total=sub1+sub2+sub3;
            Console.WriteLine("Total marks: {0}",total);
            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("Total marks: {0}", per);
            if (per >= 75)
            {
                grade = "Distinction";
            }
            else if (per >= 60 && per < 75) 
            {
                grade = "First";
            }
            else
            {
                grade = "Fail";
            }
            Console.WriteLine("Grade: {0}", grade);
            Console.ReadKey();
        }
    }
}
