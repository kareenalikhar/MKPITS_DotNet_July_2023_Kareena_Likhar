using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_employee_salary
{
    class Employee
    {
        string name;
        int empid;
        int salary;

        public void getdata(string name,int empid,int salary)
        {
            this.name = name;
            this.empid = empid;
            this.salary = salary;
        }
        public void displaydata() 
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Employee id: " + empid);
            Console.WriteLine("Salary: " + salary);
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[3];
            emp[0] = new Employee();
            emp[1] = new Employee();
            emp[2] = new Employee();

            string ename;
            int eid;
            int sal;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Employee Name");
                ename = Console.ReadLine();
                Console.WriteLine("Enter Employee Id");
                eid =Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("Enter Salary");
                sal = Convert.ToInt32(Console.ReadLine());
                emp[i].getdata(ename,eid,sal);

            }
            Array.Sort(emp);
            int n = emp.Length - 1;
            
                Console.WriteLine(n);
            
            for (int i = 0;i < 3;i++)
            {
                emp[i].displaydata();
            }
            

            Console.ReadKey();
        }
    }
}
