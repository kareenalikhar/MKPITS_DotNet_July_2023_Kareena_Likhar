using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generic_collection_class_cutomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int,Customer> cust= new Dictionary<int,Customer>();
        
        private void button1_Click(object sender, EventArgs e)
        {
            Customer c1 = new Customer(Convert.ToInt32(textBox1.Text), textBox2.Text);
            Customer c2 = new Customer(Convert.ToInt32(textBox3.Text),textBox4.Text);
            cust.Add(c1.id, c1);
            cust.Add (c2.id, c2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb=new StringBuilder();
            foreach(KeyValuePair<int,Customer> kvp in cust)
            {
                sb.Append(kvp.Key + " : "+ kvp.Value.name + "\n");
            }
            label5.Text = sb.ToString();
        }
    }
}
