//15. Write a C# Sharp program to check whether a triangle can be formed
//by the given angles value.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_triangle_valid15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a1, a2, a3;
            a1 = Convert.ToInt32(textBox1.Text);
            a2 = Convert.ToInt32(textBox2.Text);
            a3 = Convert.ToInt32(textBox3.Text);
            if (a1 + a2 + a3 == 180)
            {
                label4.Text=("Result: The triangle is valid.");
            }
            else
            {
                label4.Text=("Result: The triangle is not valid.");
            }
        }
    }
}
