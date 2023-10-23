//24. Write a C# Sharp program that calculates the area of geometrical shapes using a menu-driven approach.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_geometrical24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int choice;
           
            choice = Convert.ToInt32(textBox1.Text);
            if (choice == 1)
            {
                int radius;
                float area;
                radius = Convert.ToInt32(textBox5.Text);
                area = 3.14f * radius * radius;
                label6.Text=("Result: Area of Circle: " + area);
            }
            else if (choice == 2)
            {
                int l, b;
                float area1;
                l = Convert.ToInt32(textBox2.Text);
                b = Convert.ToInt32(textBox3.Text);
                area1 = l * b;
                label6.Text=("Result: Area of rectangle: " + area1);
            }
            else if (choice == 3)
            {
                int l, h;
                float area2;
                l = Convert.ToInt32(textBox2.Text);
                h = Convert.ToInt32(textBox4.Text);
                area2 = 0.5f * l * h;
                label6.Text=("Result: Area of rectangle: " + area2);
            }
        }
    }
}
