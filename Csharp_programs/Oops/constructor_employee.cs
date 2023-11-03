using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_employee
{
    class Employee
    {
        int empno;
        string empname;
        string designation;
        int salary;

        public Employee() 
        {
            empno = 123;
            empname = "Kareena";
            designation = "Manager";
            salary = 65000;
        }

        public void display()
        {
            Console.WriteLine("Employee No: " + empno);
            Console.WriteLine("Employee Name: " + empname);
            Console.WriteLine("Employee Designation: " + designation);
            Console.WriteLine("Employee Salary: " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.display();
            Console.ReadKey();
        }
    }
}
