using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_nonstatic_class_student
{
    class student
    {
        public static void display()
        {
            Console.WriteLine("Hello from display");
        }
        public void sayhi()
        {
            Console.WriteLine("hello from sayhi");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student.display();

            student s1= new student();
            s1.sayhi();
            Console.ReadKey();
        }
    }
}
