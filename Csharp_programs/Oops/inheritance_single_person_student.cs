using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_person_student
{
    class Person
    {
        public string name;
        public string address;
    }
    class Student:Person
    {
        public int rno;
        public int marks;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std=new Student();
            std.name = "Kareena";
            std.address = "Nagpur";
            std.rno = 1;
            std.marks = 100;

            Console.WriteLine("Name: "+std.name);
            Console.WriteLine("Address: " + std.address);
            Console.WriteLine("Roll no: " + std.rno);
            Console.WriteLine("Marks: " + std.marks);

            Console.ReadKey();
        }
    }
}
