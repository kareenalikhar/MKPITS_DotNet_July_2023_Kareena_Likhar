using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_student_array
{

    class Student
    {
        string name;
        int rollno;
        int[] submarks=new int[3];
        float average;
        int total=0;
        public void getdata(string name, int rollno, int[] submarks)
        {
            this .name = name;
            this .rollno = rollno;
            this .submarks = submarks;
            
        }
        public void displaydata()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Roll no: "+rollno);
            for (int i = 0; i < 3; i++)
            {
                total = total + submarks[i];
            }
            average = total / 3.0f;
            Console.WriteLine("Total marks: " + total);
            Console.WriteLine("Average: " + average);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            Console.WriteLine("Enter name,rollno: ");
            string name=Console.ReadLine();
            int rollno=Convert.ToInt32(Console.ReadLine());
            int[] submarks = new int[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter marks: ");
                submarks[i] = Convert.ToInt32(Console.ReadLine());
            }
            stud.getdata(name, rollno, submarks);
            stud.displaydata();

            Console.ReadKey();
        }
    }
}
