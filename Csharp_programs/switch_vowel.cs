//wap to accept a character and print whether it is vowel or not

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_vowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op;
            Console.Write("Enter Character: ");
            op=Convert.ToChar(Console.ReadLine());
            switch(op)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("It is vowel :)");
                    break;
                default:
                    Console.WriteLine("It is consonant :(");
                    break;

            }
            Console.ReadKey();
        }
    }
}
