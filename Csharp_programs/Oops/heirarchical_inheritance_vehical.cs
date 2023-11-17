using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heirarchical_inheritance_vehical
{
    class Vehical
    {
        
        public void startvehical()
        {
            Console.WriteLine("Vehical is started");
        }
        public void stopvehical()
        {
            Console.WriteLine("Vehical is stopped");
        }
    }
    class Car:Vehical
    {
        public void startcar()
        {
            Console.WriteLine("Car is started");
        }
        public void stopcar()
        {
            Console.WriteLine("Car is stopped");
        }
    }
    class truck : Vehical
    {
        public void starttruck()
        {
            Console.WriteLine("truck is started");
        }
        public void stoptruck()
        {
            Console.WriteLine("Truck is stopped");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.startcar();
            car.stopcar();

            truck truck = new truck();
            truck.starttruck();
            truck.stoptruck();

            Console.ReadKey();
        }
    }
}
