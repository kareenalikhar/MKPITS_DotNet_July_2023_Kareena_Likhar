using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_product
{
    class Product
    {
        int productid;
        string productname;
        int productprice;
        int productquantity;

        public Product() 
        {
            productid = 123;
            productname = "Pen";
            productprice = 10;
            productquantity = 20;
        }

        public void display()
        {
            Console.WriteLine("Product Id: " + productid);
            Console.WriteLine("Product Name: " + productname);
            Console.WriteLine("Product Price: " + productprice);
            Console.WriteLine("Product Quantity: " + productquantity);
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.display();
            Console.ReadKey();
        }
    }
}
