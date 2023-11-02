using System;
using System.Text;

namespace oops_employee_salary
{
    class Employee
    {
        public string name { get; set; }
        public int empid { get; set; }
        public double salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[3];
            int cnt = 0;

            while (cnt < 3)
            {
                emp[cnt] = new Employee();

                Console.Write("Enter employee id: ");
                emp[cnt].empid = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter employee name: ");
                emp[cnt].name = Console.ReadLine();

                Console.Write("Enter employee salary: ");
                emp[cnt].salary = Convert.ToDouble(Console.ReadLine());

                cnt++;

                if (cnt == 3)
                {
                    Console.WriteLine("Details of 3 employees accepted");
                    break;
                }
            }

            // Code to display employee details
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("----------------------------------------\n");
                Console.WriteLine("Employee id: "+emp[i].empid);
                Console.WriteLine("Employee name: " + emp[i].name);
                Console.WriteLine("Employee Salary: " + emp[i].salary);
                Console.WriteLine("----------------------------------------");
            }


            // Code to find employee with highest salary
            double high = emp[0].salary;
            int foundat = 0;
            for (int i = 1; i < 3; i++)
            {
                if (emp[i].salary > high)
                {
                    high = emp[i].salary;
                    foundat = i;
                }
            }

            Console.WriteLine("Employee with highest salary:");
            Console.WriteLine("Employee number:" +emp[foundat].empid);
            Console.WriteLine("Employee name: " +emp[foundat].name);
            Console.WriteLine("Employee salary: " +emp[foundat].salary);

            Console.ReadLine(); // Pause to view the output in console
        }
    }
            
}
