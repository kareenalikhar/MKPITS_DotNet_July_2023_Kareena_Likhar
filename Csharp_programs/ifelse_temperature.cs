//13. Write a C# Sharp program to read temperature in centigrade
//and display a suitable message according to the temperature state below:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_temperature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Temperature: ");
            temp=Convert.ToInt32(Console.ReadLine());
            if(temp <=0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if(temp>0 &&  temp<=10)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temp > 10 && temp <= 20)
            {
                Console.WriteLine(" Cold weather");
            }
            else if (temp > 20 && temp <= 30)
            {
                Console.WriteLine("Normal in Temp");
            }
            else if (temp > 30 && temp <= 40)
            {
                Console.WriteLine("Its Hot");
            }
            else if(temp>=40)
            {
                Console.WriteLine("Its Very Hot");
            }
            Console.ReadKey();
        }
    }
}
