using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_generic_collection_customer_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        Dictionary<int,string> li=new Dictionary<int,string>();
        private void button1_Click(object sender, EventArgs e)
        {
            Customer c1=new Customer(Convert.ToInt32(textBox1.Text), textBox2.Text);
            li.Add(c1.Id, c1.Name);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();
            foreach(KeyValuePair<int,string> kvp in li)
            {
                sb.Append(kvp.Key +" : "+ kvp.Value + "\n");
            }
            label3.Text = sb.ToString();
        }
    }
}
