//6- wap to accept 5 subject marks using for loop,calculate total, per and grade

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_5submarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, cnt, total = 0;
            float per=0.0f;
            string grade;
            for(cnt = 1; cnt <= 5;cnt++)
            {
                Console.Write("Enter Marks: ");
                num=Convert.ToInt32(Console.ReadLine());
                total = total + num;
                per = (total / 500.0f) * 100.0f;
                
            }
            if (per >= 75)
            {
                grade= "Distinction";
            }
            else if (per >= 60 && per < 75)
            {
                grade= "First";
            }
            else if (per >= 40 && per < 60)
            {
                grade = "second";
            }
            else
            {
                grade = "Fail";
            }
            Console.WriteLine("Total: " + total);
            Console.WriteLine("percentage: " + per);
            Console.WriteLine("Grade= "+grade);
            
            Console.ReadKey();
        }
    }
}
