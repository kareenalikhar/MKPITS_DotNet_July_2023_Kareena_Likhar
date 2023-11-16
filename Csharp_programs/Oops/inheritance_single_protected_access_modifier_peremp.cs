using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_protected_access_modifier_peremp
{
    class Person
    {
        string name;
        string address;

        protected void getpersondata(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        protected void displaypersondata()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
        }
    }
    class Employee: Person
    {
        int eno;
        int salary;

        public void getempdata(int  eno,int salary)
        {
            getpersondata("Kareena", "Nagpur");
            this.eno = eno;
            this.salary = salary;
        }
        public void displayempdata()
        {
            displaypersondata();
            Console.WriteLine("Employee no: "+eno);
            Console.WriteLine("Salary: " + salary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getempdata(1,500000);
            emp.displayempdata();

            Console.ReadKey();
        }
    }
}
