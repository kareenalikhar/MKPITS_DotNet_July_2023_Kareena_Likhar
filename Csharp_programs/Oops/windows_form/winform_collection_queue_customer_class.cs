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

namespace winform_collection_queue_customer_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Customer c;
        Queue q=new Queue();
        private void button1_Click(object sender, EventArgs e)
        {
            c=new Customer(Convert.ToInt32(textBox1.Text),textBox2.Text,textBox3.Text,Convert.ToInt32(textBox4.Text));
            q.Enqueue(c);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Customer c1 in q) 
            {
                sb.Append(c1.custid + " : " + c1.custname + " : " + c1.email + " : " + c1.mobno + "\n");

            }
            label5.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Customer r = (Customer)q.Dequeue();
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Item dequeue: " + r.custid + " : " + r.custname +" : " + r.email +" : "+ r.mobno+"\n");
            sb1.Append("After Dequeue: \n");
            foreach (Customer c2 in q)
            {
                sb1.Append(c2.custid + " : " + c2.custname + " : " + c2.email + " : " + c2.mobno + "\n");
            }
            label5.Text = sb1.ToString();
        }
    }
}
