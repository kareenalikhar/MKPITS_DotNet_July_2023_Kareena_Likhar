using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4class_object_car
{
    class Car
    {
        public string color;
        public string name;

        public void getdata(string color,string name)
        {
            this.color = color;
            this.name = name;
        }
        public void display()
        {
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Name: " + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.getdata("White", "Creata");
            car.display();
            Console.ReadLine();
        }
    }
}
