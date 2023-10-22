//14. Write a C# Sharp program to check whether a triangle is Equilateral,
//Isosceles or Scalene.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_triangle14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, z;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            z = Convert.ToInt32(textBox3.Text);
            if (x == y && x == z && y == z)
            {
                label4.Text=("Result: Triangle is Equilateral");
            }
            else if (x == y || x == z)
            {
                label4.Text=("Result: This is an isosceles triangle. ");
            }
            else
            {
                label4.Text=("Result: This is an Scalene triangle.");
            }
        }
    }
}
