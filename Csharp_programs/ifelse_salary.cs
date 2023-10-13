/*12- wap to accept empno , empname and basic salary and designation then calculate bonus =55% of basic salary for manager, 25% for clerk and 10% for peon
then calculate total salary*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int empno, basicsalary;
            float bonus=0, total;
            string empname, designation;
            Console.Write("Employee number: ");
            empno=Convert.ToInt32(Console.ReadLine());
            Console.Write("Employee name: ");
            empname = Console.ReadLine();
            Console.Write("Basic Salary: ");
            basicsalary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Designation: ");
            designation = Console.ReadLine();

            if (designation == "manager") 
            {
                bonus = basicsalary * 0.55f;
            }
            else if (designation == "clerk") 
            {
                bonus = basicsalary * 0.25f;
            }
            else if (designation == "peon") 
            {
                bonus = basicsalary * 0.10f;
            }
            else
            {
                Console.WriteLine("invalid post entered:");
            }
            total = basicsalary + bonus;

            Console.WriteLine("empno: {0} empname: {1} basicsalary: {2} designation: {3} ",empno,empname,basicsalary,designation);
            Console.WriteLine("bonus: {0} total: {1}", bonus, total);
            Console.ReadKey();

        }
    }
}
