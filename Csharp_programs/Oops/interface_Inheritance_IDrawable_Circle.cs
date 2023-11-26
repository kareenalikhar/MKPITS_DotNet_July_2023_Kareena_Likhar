using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_Inheritance_IDrawable_Circle
{
    interface IDrawable
    {
        string Draw();
    }
    class Circle:IDrawable
    {
        public string Draw()
        {
            return "Circle Drawing..";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IDrawable d= new Circle();
            string res=d.Draw();
            Console.WriteLine(res);

            Console.ReadKey();

        }
    }
}
