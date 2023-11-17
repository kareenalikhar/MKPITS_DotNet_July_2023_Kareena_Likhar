using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hierarchical_inheritance_person_student_emp_method
{
    public class Person
    {
        String name;
        String address;
        public void getPersonData(String name, String address)
        {
            this.name = name;
            this.address = address;
        }
        public void displayPersonData()
        {
            Console.WriteLine("name : " + name);
            Console.WriteLine("address : " + address);

        }
    }

    public class Student : Person
    {

        int rno;
        int marks;
        public void getStudentData(int rno, int marks)
        {
            this.rno = rno;
            this.marks = marks;
        }
        public void displayStudentData()
        {
            Console.WriteLine("rno : " + rno);
            Console.WriteLine("marks : " + marks);

        }
    }
    public class Employee : Person
    {
        int salary;
        String designation;
        public void getEmployeeData(int salary, String designation)
        {
            this.salary = salary;
            this.designation = designation;
        }
        public void displayEmployeeData()
        {
            Console.WriteLine("salary : " + salary);
            Console.WriteLine("designation : " + designation);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student p1 = new Student();
            p1.getPersonData("arifa", "nagpur");
            p1.getStudentData(111, 999);
            p1.displayPersonData();
            p1.displayStudentData();

            Employee e1 = new Employee();
            e1.getPersonData("monish", "nagpur");
            e1.getEmployeeData(9999, "manager");
            e1.displayPersonData();
            e1.displayEmployeeData();
            Console.ReadKey();

        }
    }
}
