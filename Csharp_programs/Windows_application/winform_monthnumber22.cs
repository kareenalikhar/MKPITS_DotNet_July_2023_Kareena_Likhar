//22. Write C# Sharp program to read any Month Number in integer and display Month name.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_monthnumber22
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
            int num=Convert.ToInt32(textBox1.Text);
            if(num == 1 ) {
                label2.Text = "Result: January";
            }
            else if(num == 2 )
            {
                label2.Text = "Result: February";
            }
            else if (num == 3)
            {
                label2.Text = "Result: March";
            }
            else if (num == 4)
            {
                label2.Text = "Result: April";
            }
            else if (num == 5)
            {
                label2.Text = "Result: May";
            }
            else if (num == 6)
            {
                label2.Text = "Result: June";
            }
            else if (num == 7)
            {
                label2.Text = "Result: July";
            }
            else if (num == 8)
            {
                label2.Text = "Result: August";
            }
            else if (num == 9)
            {
                label2.Text = "Result: September";
            }
            else if (num == 10)
            {
                label2.Text = "Result: October";
            }
            else if (num == 11)
            {
                label2.Text = "Result: November";
            }
            else if (num == 12)
            {
                label2.Text = "Result: December";
            }
            else
            {
                label2.Text = "Invalid Month Number";
            }
        }
    }
}
