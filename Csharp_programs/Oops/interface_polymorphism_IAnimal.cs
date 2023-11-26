using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_polymorphism_IAnimal
{
    interface IAnimal
    {
        string MakeSound();

    }
    class Dog:IAnimal
    {
        public string MakeSound()
        {
            return "Dog sound is Bow Bow";
        }

    }
    class Cat : IAnimal
    {
        public string MakeSound()
        {
            return "Cat sound is meow meow";
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal a= new Dog();
            string res=a.MakeSound();
            Console.WriteLine(res);

            IAnimal b=new Cat();
            string res2=b.MakeSound();
            Console.WriteLine(res2);

            Console.ReadKey();
        }
    }
}
