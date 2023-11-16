using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_person
{
    class person
    {
        public string name;
    }
    class student:person
    {
        public int rno;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student s=new student();
            s.rno = 1;
            s.name = "Kareena";
            Console.WriteLine("Roll no: " + s.rno);
            Console.WriteLine("Name: " + s.name);

            Console.ReadKey();
        }
    }
}
