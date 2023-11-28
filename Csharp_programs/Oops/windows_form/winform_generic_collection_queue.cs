using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_generic_collection_queue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Queue<string> q = new Queue<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            q.Enqueue(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            q.Dequeue();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb=new StringBuilder();
            foreach(string s in q) 
            {
                sb.Append(s +"\n");
            }
            label2.Text = sb.ToString();
        }
    }
}
