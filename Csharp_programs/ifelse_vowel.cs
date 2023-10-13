//16. Write a C# Sharp program to check whether an alphabet letter is a vowel or a consonant.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_vowel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter Character: ");
            ch=Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u') 
            {
                Console.WriteLine("It is vowel");
            }
            else
            {
                Console.WriteLine("It is Consonant");
            }
            Console.ReadKey();
        }
    }
}
