using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_inheriting_method_animals
{
    class Animals
    {
        public void eating()
        {
            Console.WriteLine("Eating....");
        }
    }
    class Dog: Animals
    {
        public void barking()
        {
            Console.WriteLine("Barking....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d= new Dog();
            d.eating();
            d.barking();

            Console.ReadKey();
        }
    }
}
