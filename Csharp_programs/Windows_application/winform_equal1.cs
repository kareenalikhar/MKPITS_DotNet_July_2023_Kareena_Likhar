using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_equal1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //1. Write a C# Sharp program to
        //accept two integers and check whether they are equal or not.
        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox1.Text);
            int num2 = Convert.ToInt32(textBox2.Text);
            if(num1 == num2)
            {
                label3.Text = "Num1 is equal to num2:)";
            }
            else
            {
                label3.Text = "Num1 is not equal to num2:)";
            }
            


        }
    }
}
