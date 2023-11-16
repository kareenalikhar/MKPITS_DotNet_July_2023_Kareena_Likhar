using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_protected_peremp
{
    class Person
    {
        string name;

        protected void getpersondata(string name)
        {
            this.name = name;
            Console.WriteLine("Name: " + name);
        }
    }
    class Employee:Person
    {
        int empno;

        internal void getemployeedata(string name,int empno) 
        {
            getpersondata(name);
            this.empno = empno;
            Console.WriteLine("Empno: " + empno);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.getemployeedata("kareena", 123);

            Console.ReadKey();
        }
    }
}
