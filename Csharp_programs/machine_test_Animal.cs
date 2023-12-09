using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace machine_test_Animal
{
    class Animal
    {
        public string name { get; set; }
        public int age { get; set; }

        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void MakeSound()
        {
            Console.WriteLine("Animal make sound");
        }
        public void display()
        {

        }
    }

    class Mammal : Animal
    {
        public string FurColor { get; set; }

        public Mammal(string name, int age, string FurColor):base(name, age) 
        {
            this.FurColor = FurColor;
        }
        public void walk()
        {
            Console.WriteLine("Mammal is walking");
        }
    }
    class Reptile:Animal
    {
        public bool Iscoldblooded { get; set; }

        public Reptile(string name, int age, bool Iscoldblooded) : base(name, age)
        {
            this.Iscoldblooded = Iscoldblooded;
        }
        public void Crawl()
        {
            Console.WriteLine("Reptile is Crawling");
        }
    }

    class Bird:Animal
    {
        public int wing { get; set; }

        public Bird(string name, int age, int wing) : base(name, age)
        {
            this.wing = wing;
        }
        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }
    }

    class Lion:Mammal
    {
        public Lion(string name, int age, string furColor) : base(name, age, furColor) 
        { 
        
        }
        public void makesound()
        {
            Console.WriteLine("The Lion Roars Loaudly");
        }
        public void display()
        {
            Console.WriteLine("name: "+name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Furcolor: " + FurColor);
        }

    }
    class Snake:Reptile
    {
        public Snake(string name, int age, bool Iscoldblooded) : base(name, age, Iscoldblooded)
        {

        }
        public void makesound()
        {
            Console.WriteLine("The Snake hiss");
        }
        public void display()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Iscoldblooded: " + Iscoldblooded);
        }
    }
    class Eagle:Bird
    {
        public Eagle(string name, int age, int wing) : base(name, age, wing)
        {

        }1
        public void makesound()
        {
            Console.WriteLine("The eagle screeches");
        }
        public void display()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("wing: " + wing);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Lion l = new Lion("Simbha", 3, "Orange");
            l.display();
            l.walk();
            Snake s = new Snake("Kaa", 5, true);
            s.display();
            s.Crawl();
            Eagle e = new Eagle("Eeglu", 2, 4);
            e.display();
            e.Fly();
          
             Console.ReadKey();
            }
        }
    }

