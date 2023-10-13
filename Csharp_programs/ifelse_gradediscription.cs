//19. Write a program in C# Sharp to accept a grade and declare the equivalent description :

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelse_gradediscription
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char grade;
            Console.WriteLine("Enter grade: ");
            grade=Convert.ToChar(Console.ReadLine());
            if(grade == 'a')
            {
                Console.WriteLine("Average");
            }
            else if (grade == 'e')
            {
                Console.WriteLine("Excellent");
            }
            else if (grade == 'v')
            {
                Console.WriteLine("Very Good");
            }
            else if (grade == 'g')
            {
                Console.WriteLine("Good");
            }
            else if (grade == 'f')
            {
                Console.WriteLine("Fail");
            }
            Console.ReadKey();
        }
    }
}
