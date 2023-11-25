using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collection_queue_customer_class
{
    class Customer
    {
        public int custid;
        public string custname;
        public string email;
        public int mobno;

        public Customer(int custid,string custname,string email,int mobno) 
        {
            this.custid = custid;
            this.custname = custname;
            this.email = email;
            this.mobno = mobno;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Customer c = new Customer(1, "Kareena", "kareena@gmail.com", 123456789);
            Customer c1 = new Customer(2, "Rohit", "rohit@gmail.com", 123456789);
            Customer c2 = new Customer(3, "Yashit", "yashit@gmail.com", 123456789);
            Queue q= new Queue();
            q.Enqueue(c);
            q.Enqueue(c1);
            q.Enqueue(c2);

            foreach(Customer cust in q)
            {
                Console.WriteLine(cust.custid+ " : "+ cust.custname + " : "+ cust.email + " : "+ cust.mobno);
            }

            Customer r=(Customer)q.Dequeue();
            Console.WriteLine("_____________________");
            Console.WriteLine("After Dequeue");

            Console.WriteLine("Item Dequeue: "+r.custid + " : " + r.custname + " : " + r.email + " : " + r.mobno);
            foreach (Customer cust1 in q)
            {
                Console.WriteLine(cust1.custid + " : " + cust1.custname + " : " + cust1.email + " : " + cust1.mobno);
            }

            Console.ReadKey();
        }
    }
}
