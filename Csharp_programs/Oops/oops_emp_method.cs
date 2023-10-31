using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_employee_method
{
    class Employee
    {
        int empno;
        string empname;
        string designation;
        int salary;

        public void getdata(int empno, string empname, string designation, int salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.designation = designation;
            this.salary = salary;
        }

        public void displaydata()
        {
            Console.WriteLine("Employee no: " + empno);
            Console.WriteLine("Employee name: " + empname);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Salary: " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                Employee emp=new Employee();
                Console.WriteLine("Enter employee no,name,designation,salary: ");
            int no=Convert.ToInt32(Console.ReadLine());
            string name=Console.ReadLine();
            string desig=Console.ReadLine();
            int sal=Convert.ToInt32(Console.ReadLine());
            emp.getdata(no, name, desig, sal);
            emp.displaydata();

            Console.ReadKey();
        }
    }
}
