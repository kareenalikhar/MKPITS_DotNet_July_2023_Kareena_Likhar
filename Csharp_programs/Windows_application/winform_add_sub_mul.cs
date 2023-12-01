using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_add_sub_mul
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculation c=new Calculation();
        private void button1_Click(object sender, EventArgs e)
        {
            c.Add(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = c.display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c.Sub(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = c.display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c.Mul(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            label3.Text = c.display();
        }
    }
}
