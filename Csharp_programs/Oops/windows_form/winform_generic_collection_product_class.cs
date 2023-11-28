using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_generic_collection_product_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int,Product> pro=new Dictionary<int,Product>();
        
        private void button1_Click(object sender, EventArgs e)
        {
            Product p=new Product(Convert.ToInt32(textBox1.Text),textBox2.Text,Convert.ToInt32(textBox3.Text),Convert.ToInt32(textBox4.Text));
            pro.Add(Convert.ToInt32(textBox1.Text),p);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
            MessageBox.Show("customer objects added to dictionary colletion");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int total = 0;
            StringBuilder sb= new StringBuilder();
            foreach(KeyValuePair<int,Product> kvp in pro)
            {
                int amount=kvp.Value.rate* kvp.Value.quantity;
                total=total+amount;
                sb.Append(kvp.Key + " : "+ kvp.Value.Name + " : "+ kvp.Value.rate+" : "+kvp.Value.quantity + " : "+ "Amount: "+amount+  "\n");
                label6.Text = "Total : " + total;
            }
            label5.Text = sb.ToString();
        }
    }
}
