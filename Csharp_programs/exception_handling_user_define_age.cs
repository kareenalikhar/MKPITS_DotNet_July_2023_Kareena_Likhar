using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling_user_define_age
{
    class AgeException:ApplicationException
    {
        public AgeException(string message) : base(message)
        { }
    }
        class Age
    {
        public int age = 22;
        public void showage()
        {
            if(age<=18)
            {
                throw new AgeException("Age is greater than 18");
            }
            else
            {
                Console.WriteLine("Age: "+age);
            }
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Age a= new Age();
            try
            {
                a.showage();
            }
            catch(AgeException ae)
            {
                Console.WriteLine(ae.ToString());
            }
            Console.ReadLine();
        }

    }
}
