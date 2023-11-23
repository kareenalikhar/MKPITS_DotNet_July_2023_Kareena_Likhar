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

namespace winform_collection_remove_numbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ar=new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            ar.Add(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Capacity: " + ar.Capacity);

            StringBuilder sb = new StringBuilder();
            foreach(int i in ar)
            {
                sb.Append("Number: " + i + "\n");
            }
            label3.Text = sb.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ar.Insert(2,Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ar.Remove(Convert.ToInt32(textBox1.Text));
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ar.RemoveAt(Convert.ToInt32(textBox2.Text));
            textBox2.Clear();
            textBox2.Focus();
        }
    }
}
