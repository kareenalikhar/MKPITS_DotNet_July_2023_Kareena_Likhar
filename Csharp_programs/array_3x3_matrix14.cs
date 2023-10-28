using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_3x3_matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,]arr=new int[3,3];
            Console.WriteLine("Input element in the matrix: \n");
            for(i=0;i<3;i++)
            {
                for(j=0;j<3;j++)
                {
                    Console.Write("Element - [{0},{1}]: ", i, j);
                    arr[i,j]=Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Write("The matrix is: \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                {
                    Console.Write("{0}\t", arr[i,j]);
                }
            }
            Console.ReadKey();

        }
    }
}
