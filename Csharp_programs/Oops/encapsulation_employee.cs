using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_employee
{
    class Employee
    {
        public string name { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.name = "Kareena";
            Console.WriteLine("Name: "+e.name);
            Console.ReadKey();
        }
    }
}
