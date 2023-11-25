using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2inheritance_vehical
{
    class Vehical
    {
        public int make;
        public string model;
        
    }
    class Car:Vehical
    {
        public int numDoors;
        public string fueltype;

        public void getdata(int make, string model,int numDoors,string fueltype) 
        {
            this.make = make;
            this.model = model;
            this.numDoors = numDoors;
            this.fueltype = fueltype;
        }
        public void displaydata()
        {
            Console.WriteLine("Make: " + make);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Number of Doors: " + numDoors);
            Console.WriteLine("Fuel type: " + fueltype);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Date of make: ");
            int make=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Model of car: ");
            string model = Console.ReadLine();
            Console.WriteLine("Number of doors: ");
            int noofdoor=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fuel type: ");
            string ft=Console.ReadLine();
            Car c= new Car();
            c.getdata(make, model, noofdoor, ft);
            c.displaydata();

            Console.ReadLine();
        }
    }
}
