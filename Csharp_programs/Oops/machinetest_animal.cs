using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machinetest_animal
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }

    class Mammal : Animal
    {
        public Mammal(string name, int age) : base(name, age)
        {
        }

        // Additional properties or methods specific to mammals
    }

    class Reptile : Animal
    {
        public Reptile(string name, int age) : base(name, age)
        {
        }

        // Additional properties or methods specific to reptiles
    }

    class Bird : Animal
    {
        public Bird(string name, int age) : base(name, age)
        {
        }

        // Additional properties or methods specific to birds
    }

    class Lion : Mammal
    {
        public Lion(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Roar!");
        }

        // Additional properties or methods specific to lions
    }

    class Snake : Reptile
    {
        public Snake(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hiss!");
        }

        // Additional properties or methods specific to snakes
    }

    class Eagle : Bird
    {
        public Eagle(string name, int age) : base(name, age)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine("Screech!");
        }

        // Additional properties or methods specific to eagles
    }

    class Program
    {
        static void Main()
        {
            // Create instances of different animal types
            Lion lion = new Lion("Simba", 5);
            Snake snake = new Snake("Nagini", 3);
            Eagle eagle = new Eagle("Thunder", 2);

            // Demonstrate polymorphism by calling the common method on objects of different derived classes
            Animal[] animals = { lion, snake, eagle };

            foreach (var animal in animals)
            {
                Console.WriteLine($"Name: {animal.Name}, Age: {animal.Age}");
                animal.MakeSound();
            }
            Console.ReadKey();
        }
    }

}
