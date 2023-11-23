using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collection_arraylist_studentname_rno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar=new ArrayList();
            ar.Add(11);
            ar.Add(12);
            ar.Add(13);

            foreach(int i in ar) 
            {
                Console.WriteLine("Student rno: "+i);
            }
            Console.ReadKey();
        }
    }
}
