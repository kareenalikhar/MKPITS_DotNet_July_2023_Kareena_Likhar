using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_method_Dog
{
    class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Animal Eating...");
        }
        public virtual void run()
        {
            Console.WriteLine("Animal Running...");
        }
    }
    class Dog: Animal
    {
        public override void eat()
        {
            Console.WriteLine("Dog Eating...");
        }
        public sealed override void run()
        {
            Console.WriteLine("Dog Eating...");
        }
    }
    class BabyDog : Dog
    {
        public override void eat()
        {
            Console.WriteLine("Dog Eating...");
        }
        public override void run()
        {
            Console.WriteLine("Dog Eating...");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BabyDog dog = new BabyDog();
            dog.eat();
            dog.run();
        }
    }
}
