//20. Write a C# Sharp program to read any day number as an integer and
//display the name of the day as a word.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_daynumber20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day;
            day=Convert.ToInt32(textBox1.Text);
            if(day==1)
            {
                label2.Text = "Result: Sunday";
            }
            else if (day == 2)
            {
                label2.Text = "Result: Monday";
            }
            else if (day == 3)
            {
                label2.Text = "Result: Tuesday";
            }
            else if(day == 4)
            {
                label2.Text = "Result: Wednesday";
            }
            else if(day == 5)
            {
                label2.Text = "Result: Thusday";
            }
            else if(day == 6)
            {
                label2.Text = "Result: Friday";
            }
            else if(day == 7)
            {
                label2.Text = "Result: Saturday";
            }
            else
            {
                label2.Text = "Invalid day number";
            }
        }
    }
}
