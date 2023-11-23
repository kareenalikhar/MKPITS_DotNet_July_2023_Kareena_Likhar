using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace winform_collection_arraylist_product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        product p;
        ArrayList arr=new ArrayList();
        
        private void button1_Click(object sender, EventArgs e)
        {
            p=new product(Convert.ToInt32(textBox1.Text),textBox2.Text,Convert.ToInt32(textBox3.Text));
            arr.Add(p);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (product pro in arr)
            {
                sb.Append("Product id: " + pro.productid + " Product Name: " + pro.productname + " Product Rate: " + pro.productprice + "\n");
            }
            label5.Text = sb.ToString();
        }
    }
}
