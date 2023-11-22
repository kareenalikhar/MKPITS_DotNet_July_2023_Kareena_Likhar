using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_student
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stud = new Student();
            stud.Id = 1;
            stud.Name = "Kareena";
            stud.EmailId = "kareenalikhar@gmail.com";

            Console.WriteLine("Student id: " + stud.Id);
            Console.WriteLine("Student Name: "+stud.Name);
            Console.WriteLine("Student Email: " + stud.EmailId);

            Console.ReadKey();
        }
    }
}
