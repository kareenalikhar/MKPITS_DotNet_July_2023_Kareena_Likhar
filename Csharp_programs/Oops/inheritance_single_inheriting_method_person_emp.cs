using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_inheriting_method_person_emp
{
    class Person
    {
        string name;
        string address;

        public void getpersondata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersondata()
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Address: " + address);
        }
    }
    class Employee:Person
    {
        int empno;
        int salary;

        public void getempdata(int empno, int salary)
        {
            this.empno = empno;
            this.salary = salary;
        }
        public void displayempdata()
        {
            Console.WriteLine("Emp no: "+empno);
            Console.WriteLine("Salary: " + salary);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getpersondata("Kareena", "Nagpur");
            emp.getempdata(123, 500000);
            emp.displaypersondata();
            emp.displayempdata();

            Console.ReadKey();
        }
    }
}
