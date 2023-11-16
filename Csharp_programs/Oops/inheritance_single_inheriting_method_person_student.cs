using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_inheriting_method_person_student
{
    class Person
    {
         string name;
         string address;

        public void getpersondata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersondata()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
        }
    }
    class Student:Person
    {
        int rno;
        int marks;

        public void getstudentdata(int rno, int marks)
        {
            this.rno = rno;
            this.marks = marks;
        }
        public void displaystudentdata()
        {
            Console.WriteLine("Roll no: " + rno);
            Console.WriteLine("Marks: " + marks);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud= new Student();
            stud.getpersondata("Kareena", "Nagpur");
            stud.getstudentdata(123, 100);
            stud.displaypersondata();
            stud.displaystudentdata();

            Console.ReadKey();
        }
    }
}
