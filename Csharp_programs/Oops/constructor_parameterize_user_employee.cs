using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace constructor_parameterize_user_employee
{
    class Employee
    {
        int id;
        string name;
        string designation;
        int salary;

        public Employee(int id,string name,string designation,int salary) 
        {
            this.id = id;
            this.name = name;
            this.designation = designation;
            this.salary = salary;
        }

        public void display()
        {
            Console.WriteLine("Employee id: " + id);
            Console.WriteLine("Employee name: " + name);
            Console.WriteLine("Employee designation: " + designation);
            Console.WriteLine("Employee salary: " + salary);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee id: ");
            int i1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee name: " );
            string n1=Console.ReadLine();
            Console.WriteLine("Employee designation: ");
            string d1=Console.ReadLine();
            Console.WriteLine("Employee salary: ");
            int s1=Convert.ToInt32(Console.ReadLine()); 
            Employee emp=new Employee(i1,n1,d1,s1);
            emp.display();
            Console.ReadKey();
        }
    }
}
