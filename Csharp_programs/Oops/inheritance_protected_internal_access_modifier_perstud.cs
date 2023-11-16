using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_protected_internal_access_modifier_perstud
{
    class Person
    {
        string name;
        string address;

        protected internal void getpersondata(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
        protected internal void displaypersondata()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Address: " + address);
        }
    }
    class Student:Person
    {
        int rno;
        int marks;

        public void getstuddata(int rno, int marks)
        {
            this.rno = rno;
            this.marks = marks;
        }
        public void displaystuddata()
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
            stud.getstuddata(123, 100);
            stud.displaypersondata();
            stud.displaystuddata();

            Console.ReadKey();
        }
    }
}
