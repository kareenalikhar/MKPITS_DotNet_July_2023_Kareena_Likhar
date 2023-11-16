using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_inheriting_method_car
{
    class car
    {
        public void start()
        {
            Console.WriteLine("Car is starting...");
        }
    }
    class Creata:car
    {
        public void startmusic()
        {
            Console.WriteLine("Music is staring....");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Creata car=new Creata();
            car.start();
            car.startmusic();

            Console.ReadKey();
        }
    }
}
