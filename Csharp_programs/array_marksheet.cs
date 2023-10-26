using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_marksheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sub = new int[5];
            int total = 0;
            float per;
            string grade=null;
            for(int i=0;i<5;i++)
            {
                Console.WriteLine("Enter Marks: ");
                sub[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<5; i++)
            {
                total = total + sub[i];
            }
            Console.WriteLine("Total Marks: " + total);
            per = (total / 500.0f) * 100.0f;
            Console.WriteLine("Percentage: " + per);
            if(per>=75)
            {
                grade = "Distinction";
            }
            else if(per>=60 && per<75)
            {
                grade = "First class";
            }
            else if (per >= 40 && per < 60)
            {
                grade = "Second class";
            }
            else
            {
                Console.WriteLine("Fail");
            }
            Console.WriteLine("Grade: {0}",grade);

            Console.ReadKey();
        }
    }
}
