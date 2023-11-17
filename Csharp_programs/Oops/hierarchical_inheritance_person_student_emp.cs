using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_inheritance_person_student_emp
{
    class Person
    {
        public string name;
        public string address;
    }
    class Employee:Person
    {
        public int empno;
        public int salary;
    }
    class Student:Person
    {
        public int rno;
        public int marks;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp=new Employee();
            emp.name = "Kareena";
            emp.address = "Nagpur";
            emp.empno= 1;
            emp.salary = 500000;
            Console.WriteLine("---------Employee Details----------");
            Console.WriteLine("Employee Name: " + emp.name);
            Console.WriteLine("Employee Address: " + emp.address);
            Console.WriteLine("Employee no: " + emp.empno);
            Console.WriteLine("Employee Salary: " + emp.salary);

            Student stud = new Student();
            stud.name = "Kareena";
            stud.address = "Nagpur";
            stud.rno = 1;
            stud.marks = 100;
            Console.WriteLine("---------Student Details----------");
            Console.WriteLine("Student Name: " + stud.name);
            Console.WriteLine("Student Address: " + stud.address);
            Console.WriteLine("Student roll no: " + stud.rno);
            Console.WriteLine("Student marks: " + stud.marks);

            Console.ReadKey();

        }
    }
}
