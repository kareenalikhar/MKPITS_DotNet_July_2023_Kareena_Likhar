using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_level_employee_programmer
{
    class Employee
    {
        public float salary = 20000;
    }
    class programmer:Employee
    {
        public float bonus = 5000;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            programmer p= new programmer();
            Console.WriteLine("Salary: "+p.salary);
            Console.WriteLine("Bonus: "+p.bonus);
            Console.ReadKey();
        }
    }
}
