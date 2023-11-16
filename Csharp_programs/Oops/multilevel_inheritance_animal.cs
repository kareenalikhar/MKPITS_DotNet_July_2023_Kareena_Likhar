using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multilevel_inheritance_animal
{
    class Animals
    {
        public void eat()
        {
            Console.WriteLine("Eating....");
        }
    }
    class Dog:Animals
    {
        public void bark()
        {
            Console.WriteLine("Bark....");
        }
    }

    class Babydog:Dog
    {
        public void weep()
        {
            Console.WriteLine("Weeping....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Babydog b= new Babydog();
            b.eat();
            b.bark();
            b.weep();

            Console.ReadKey();
        }
    }
}
