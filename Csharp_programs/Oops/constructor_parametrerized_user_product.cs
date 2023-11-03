using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_parameterized_user_product
{
    class Product
    {
        int id;
        string name;
        int price;
        int quantity;

        public Product(int id, string name, int price, int quantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public void display()
        {
            Console.WriteLine("Product id: " + id);
            Console.WriteLine("Product name: " + name);
            Console.WriteLine("Product designation: " + price);
            Console.WriteLine("Product salary: " + quantity);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product id: ");
            int i1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product name: ");
            string n1 = Console.ReadLine();
            Console.WriteLine("Product price: ");
            int d1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Product quantity: ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Product pro = new Product(i1, n1, d1, s1);
            pro.display();
            Console.ReadKey();
        }
    }
}
