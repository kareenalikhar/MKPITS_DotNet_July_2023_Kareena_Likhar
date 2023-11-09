using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_class_mymaths
{
    public static class myMaths
    {
        public static float pi = 3.14f;
        public static int cube(int n) 
        { 
            return n * n * n;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("value of pi: "+myMaths.pi);
            Console.WriteLine("Cube : " + myMaths.cube(3));
            Console.ReadKey();
        }
    }
}
