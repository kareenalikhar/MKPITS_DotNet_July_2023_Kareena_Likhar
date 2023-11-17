using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overriding_animal
{
    class Animals
    {
       public virtual void eat()
        {
            Console.WriteLine("Eating....");
        }
    }
    class Dog:Animals
    {
        public override void eat()
        {
            Console.WriteLine("Coco is eating...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animals a=new Dog();
            a.eat();

            Console.ReadKey();
        }
    }
}
