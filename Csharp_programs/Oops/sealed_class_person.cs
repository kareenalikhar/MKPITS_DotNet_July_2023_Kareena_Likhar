using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_class_person_student_parttimestudent
{
    class Person
    {
        public string name;
    }
    class Student:Person
    {
        public int rno;
    }
    sealed class parttimestud:Student
    {
        public int hours;
    }

   /* class noofstud:parttimestud //error
    {

    }*/
    internal class Program
    {
        static void Main(string[] args)
        {
            parttimestud p= new parttimestud();
            p.name = "Kareena";
            p.rno = 1;
            p.hours = 5;

            Console.WriteLine(p.name);
            Console.WriteLine(p.rno);
            Console.WriteLine(p.hours);

            Console.ReadKey();
        }
    }
}
