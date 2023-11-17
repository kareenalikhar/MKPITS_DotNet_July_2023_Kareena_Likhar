using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace runtime_polymorphism_animal_color
{
    class Animal
    {
        public string color = "White";
        
    }
    class Dog:Animal
    {
        public string color = "Black";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a=new Dog();
            Console.WriteLine(a.color);

            Console.ReadKey();
        }
    }
}
