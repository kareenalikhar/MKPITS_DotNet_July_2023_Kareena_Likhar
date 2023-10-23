//23. Write a program in C# Sharp to read any Month Number in integer
//and display the number of days for this month.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_noofdays23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day=Convert.ToInt32(textBox1.Text);
            if(day==1 || day==3|| day==5|| day==7|| day==8 || day==10 || day==12)
            {
                label2.Text = "Result: Month have 31 days";
            }
            else if(day==4 || day==6 || day==9 || day==11)
            {
                label2.Text = "Result: Month have 30 days";
            }
            else if(day==2)
            {
                label2.Text = "Result: Month have 28 or 29 days";
            }
            else
            {
                label2.Text = "Invalid Month number";
            }
        }
    }
}
