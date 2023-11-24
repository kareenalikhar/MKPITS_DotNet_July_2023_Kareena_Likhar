using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_queue_student_class
{
    class Student
    {
        public int rno;
        public string name;
        public Student(int rno, string name)
        {
            this.rno = rno;
            this.name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(11,"Kareena");
            Student s1 = new Student(12, "Rohit");
            Student s2 = new Student(13, "Yashit");

            Queue q= new Queue();
            q.Enqueue(s);
            q.Enqueue(s1); 
            q.Enqueue(s2);

            foreach(Student stud in q)
            {
                Console.WriteLine(stud.rno+" : "+stud.name);
            }

            Student r=(Student)q.Dequeue();
            Console.WriteLine("Item dequeue: " + r.rno + " : " + r.name);
            Console.WriteLine("After Dequeue: ");
            foreach(Student stud1 in q)
            {
                Console.WriteLine(stud1.rno + " : "+ stud1.name);
            }

            Console.ReadKey();

        }
    }
}
