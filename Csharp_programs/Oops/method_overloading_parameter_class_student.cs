using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overloading_parameter_class_student
{
    class Student
    {
        int rollno;
        string name;
        string course;
        int fees;

        public void getdata()
        {
            rollno = 1;
            name = "Kareena";
            course = "Bsc";
            fees = 10000;
        }
        public void getdata(int rollno)
        {
            this.rollno = rollno;
        }
        public void getdata(int rollno,string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
        public void getdata(int rollno, string name,string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }
        public void getdata(int rollno, string name, string course,int fees)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
            this.fees = fees;
        }
        public void display()
        {
            Console.WriteLine("Student Rollno: " + rollno);
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Student course: " + course);
            Console.WriteLine("Student fees: " + fees);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.getdata();
            stud.display();
            Console.WriteLine("--------------Details of student1------------");
            Student stud1 = new Student();
            stud1.getdata(1,"Rohit");
            stud1.display();
            Console.WriteLine("--------------Details of student2------------");
            Student stud2 = new Student();
            stud2.getdata(1,"Rohit","Eng");
            stud2.display();
            Console.WriteLine("--------------Details of student3------------");
            Student stud3 = new Student();
            stud2.getdata(1, "Rohit", "Eng",100000);
            stud2.display();
            Console.WriteLine("--------------Details of student4------------");

            Console.ReadKey();
        }
    }
}
