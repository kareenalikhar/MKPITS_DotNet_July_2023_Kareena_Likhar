using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_positive_negative3
{
    //3. Write a C# Sharp program to check whether a given number is positive or negative.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num=Convert.ToInt32(textBox1.Text);
            if(num>0)
            {
                label2.Text = "Result: Num is positive :)";
            }
            else if(num<0)
            {
                label2.Text = "Result: Num is Negative :)";
            }
            else
            {
                label2.Text = "Result: Num is zero :)";

            }
        }
    }
}
