﻿//11. Write a C# Sharp program to calculate the root of a quadratic equation.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_quadraticeq11
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
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int result = (b * b) - 4 * a * c;

            if (result != 0)
            {
                label4.Text = "Number is Imaginary: ";
            }
            else
            {
                label4.Text = "Number is Real: ";
            }
        }
    }
}

