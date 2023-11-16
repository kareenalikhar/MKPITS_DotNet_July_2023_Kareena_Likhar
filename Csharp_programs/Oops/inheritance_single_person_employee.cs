using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_person_employee
{
    class Person
    {
        public string name;
        public string address;
    }
    class Employee : Person
    {
        public int empno;
        public int salary;
        public string designation;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.name = "Kareena";
            emp.address = "Nagpur";
            emp.empno = 1;
            emp.salary = 100000;
            emp.designation = "Designer";

            Console.WriteLine("Name: " + emp.name);
            Console.WriteLine("Address: " + emp.address);
            Console.WriteLine("Employee no: " + emp.empno);
            Console.WriteLine("Salary: " + emp.salary);
            Console.WriteLine("Designation: " + emp.designation);

            Console.ReadKey();
        }
    }
}
