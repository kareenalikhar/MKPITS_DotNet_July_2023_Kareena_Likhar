using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_person
{
    class Person
    {
        string name;
        int age;
        string address;

        public void getdata(string name, int age, string address)
        {
            this.name = name;
            this.age = age;
            this.address = address;
        }
        public void displaydata()
        {
            Console.WriteLine("Person's Name: " + name);
            Console.WriteLine("Person's Age: " + age);
            Console.WriteLine("Person's Address: " + address);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person per=new Person();
            Console.WriteLine("Enter Person's name,age,address: ");
            string pname=Console.ReadLine();
            int page=Convert.ToInt32(Console.ReadLine());
            string paddress=Console.ReadLine() ;
            per.getdata(pname, page, paddress);
            per.displaydata();

            Console.ReadKey();
        }
    }
}
