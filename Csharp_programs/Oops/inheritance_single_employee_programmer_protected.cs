using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_employee_programmer_protected
{
    class Employee
    {
        protected int salary;
    }
    class programmer:Employee
    {
        int bonus;
        public void getdata(int salary, int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }
        public void displaydata()
        {
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Bonus: " + bonus);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            programmer p= new programmer();
            p.getdata(30000, 3000);
            p.displaydata();

            Console.ReadKey();
        }
    }
}
