using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_leapyear4
{
//4. Write a C# Sharp program to find out whether a given year is a leap year or not.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num=Convert.ToInt32(textBox1.Text);
            if(num%4==0 )
            {
                label2.Text = "Result: It is leap year";
            }
            else
            {
                label2.Text = "Result: It is not leap year";
            }
        }
    }
}
