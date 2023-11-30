using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling_user_define_temperature
{
    public class TempIsZeroException:ApplicationException
    {
        public TempIsZeroException(string message):base(message) 
        {
            
        }

    }
    public class Temperature
    {
        int temp = 0;
        public void showtemp()
        {
            if(temp==0)
            {
                throw new TempIsZeroException("temperature is zero");
            }
            else
            {
                Console.WriteLine("Temperature: "+temp);
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperature t= new Temperature();
            try
            {
                t.showtemp();
            }
            catch(TempIsZeroException ea)
            {
                Console.WriteLine(ea.ToString());
            }
            Console.ReadLine();
        }
    }
}
