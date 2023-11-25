using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_stack_employee_class
{
    class Employee
    {
        public int empno;
        public string name;
        public int salary;
        public string designation;
        public Employee(int empno, string name, int salary, string designation) 
        {
            this.empno = empno;
            this.name = name;
            this.salary = salary;
            this.designation = designation;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "Kareena", 500000, "Manager");
            Employee emp1 = new Employee(2, "Rohit", 450000, "piolet");
            Employee emp2 = new Employee(3, "Yashit", 600000, "HR");

            Stack q= new Stack();
            q.Push(emp);
            q.Push(emp1);
            q.Push(emp2);

            foreach (Employee e in q) 
            {
                Console.WriteLine(e.empno + " : "+e.name + " : "+e.salary+ " : "+ emp.designation );
            }

            Employee ep = (Employee)q.Pop();
            Console.WriteLine("Item dequeue: " + ep.empno + " : " + ep.name + " : " + ep.salary + " : " + ep.designation);
            Console.WriteLine("After Dequeue: ");
            foreach (Employee e3 in q)
            {
                Console.WriteLine(e3.empno + " : " + e3.name + " : " + e3.salary + " : " + e3.designation);
            }
            Console.ReadKey();

        }
    }
}
