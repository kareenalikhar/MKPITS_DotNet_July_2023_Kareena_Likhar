using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product pro = new Product();

            int total = 0;
            int stock = 50;
            pro.productname = textBox1.Text;
            pro.productprice = Convert.ToInt32(textBox2.Text);
            pro.productitem = Convert.ToInt32(textBox3.Text);
            if (pro.productitem > 0 && pro.productitem < stock)
            {
                int rstock = stock - pro.productitem;
                total = pro.productprice * pro.productitem;
                pro.getadata(pro.productname, pro.productprice, pro.productitem);

                StringBuilder sb = new StringBuilder();
                sb.Append("Product Name: " + pro.productname + "\n");
                sb.Append("Product Price: " + pro.productprice + "\n");
                sb.Append("Product Item: " + pro.productitem + "\n"); 
                sb.Append("Total: " + total + "\n");
                sb.Append("Remaining Stock: " + rstock + "\n");
                label4.Text = sb.ToString();
            }
            else
            {
                StringBuilder sb1 = new StringBuilder();
                sb1.Append("Insufficient in Stock");
                label4.Text = sb1.ToString();
            }

        }
    }
}
