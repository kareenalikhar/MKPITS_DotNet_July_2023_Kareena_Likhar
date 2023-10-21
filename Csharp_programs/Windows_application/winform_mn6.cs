//6. Write a C# Sharp program to read the value of an integer m and display
//the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_mn6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m=Convert.ToInt32(textBox1.Text);
            if(m>0)
            {
                label2.Text = "Result: n=1";
            }
            else if(m<0)
            {
                label2.Text = "Result: n=-1";
            }
            else if(m==0)
            {
                label2.Text = "Result: n=0";
            }
        }
    }
}
