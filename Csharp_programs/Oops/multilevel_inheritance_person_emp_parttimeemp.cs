using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_inheritance_person_emp_parttimeemp
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
            Console.WriteLine("Name: " + name);
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
            Console.WriteLine("Employee no: "+empno);
            Console.WriteLine("Salary: " + salary);
        }
    }

    class parttimeemp:Employee
    {
        int part_time_hours;
        public void gettimedata(int part_time_hours)
        {
            this.part_time_hours = part_time_hours;
        }
        public void displaytimedata()
        {
            Console.WriteLine("Part time hours: " + part_time_hours);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            parttimeemp p= new parttimeemp();
            p.getpersondata("Kareena", "Nagpur");
            p.displaypersondata();
            p.getempdata(123, 500000);
            p.displayempdata();
            p.gettimedata(5);
            p.displaytimedata();

            Console.ReadKey();
        }
    }
}
