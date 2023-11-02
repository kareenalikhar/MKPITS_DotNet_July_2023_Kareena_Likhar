using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_class_product
{
    class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int ProductItem { get; set; }

        public void getData(string ProductName, int ProductPrice, int ProductItem)
        {
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
            this.ProductItem = ProductItem;
        }
        public void display()
        {
            Console.WriteLine("Product: " + ProductName);
            Console.WriteLine("Price: " + ProductPrice);
            Console.WriteLine("Items: " + ProductItem);
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            Product pr = new Product();
            string name;
            int item, price;
            int total;
            int stock = 50;

            Console.WriteLine("Enter Product Name: ");
            name=Console.ReadLine();
            Console.WriteLine("How much you buy: ");
            item=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Amount: ");
            price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("_________________________");

            if(item>0 && item<stock)
            {
                int remaningstock = stock - item;
                total = price + item;

                pr.getData(name, price, total);

                pr.display();
                Console.WriteLine("Total Price you Purches: " + total);
                Console.WriteLine("Remaining stock are: {0}", remaningstock);
            }
            else
            {
                Console.WriteLine("Insufficient in stock");
            }
            Console.ReadKey();
        }
    }
}
