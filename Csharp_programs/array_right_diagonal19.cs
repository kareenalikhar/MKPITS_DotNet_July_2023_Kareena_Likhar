using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_right_diagonal19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2];
            int sum = 0;
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write("Element [{0}],[{1}]: ", row, col);
                    arr[row, col] = Convert.ToInt32(Console.ReadLine());
                    if (row == col)
                    {
                        sum = sum + arr[row, col];

                    }
                }
            }
            Console.WriteLine("The matrix is :");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write("{0}", arr[row, col] + "\t");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Addition of the Right Diagonal elements is :{0}", sum);
            Console.ReadKey();
        }
    }
}
