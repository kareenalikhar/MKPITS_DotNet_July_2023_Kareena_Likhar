/*13 wap to accept origin, destination, date, trainno, class, passengername 
then calculate totalfare (if lessthan 100 km then 100, between 100 and 500 km fare is 500 otherwise 800) and then print ticket details*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string origin, destination, passengername,class1;
            int date, trainno, totalfare,km;
            Console.Write("Enter origin: ");
            origin = Console.ReadLine();
            Console.Write("Enter destination: ");
            destination = Console.ReadLine();
            Console.Write("Date: ");
            date= Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter train no: ");
            trainno = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter class: ");
            class1 = Console.ReadLine();
            Console.Write("Enter pasanger name: ");
            passengername = Console.ReadLine();
            Console.Write("Kilometer: ");
            km = Convert.ToInt32(Console.ReadLine());
            if(km < 100) 
            {
                totalfare = 100;
            }
            else if (km > 100 && km < 500)
            {
                totalfare = 500;
            }
            else
            {
                totalfare = 800;
            }

            Console.Write("Origin: {0} destination: {1} Date: {2} trainno: {3} class: {3} passengername: {4}", origin, destination, date, trainno, class1, passengername);
            Console.Write("kilometer: {0} Total fare: {1}" ,km, totalfare);

            Console.ReadKey();

        }
    }
}
