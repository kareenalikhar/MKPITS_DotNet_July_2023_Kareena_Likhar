//21. Write a program in C# Sharp to read any digit, display in the word.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_wordnumber21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            num=Convert.ToInt32(textBox1.Text);
            if(num == 0 )
            {
                label2.Text = "Result: Zero";
            }
            else if(num == 1 )
            {
                label2.Text = "Result: One";
            }
            else if (num == 2)
            {
                label2.Text = "Result: Two";
            }
            else if (num == 3)
            {
                label2.Text = "Result: Three";
            }
            else if (num == 4)
            {
                label2.Text = "Result: Four";
            }
            else if (num == 5)
            {
                label2.Text = "Result: Five";
            }
            else if (num == 6)
            {
                label2.Text = "Result: Six";
            }
            else if (num == 7)
            {
                label2.Text = "Result: Seven";
            }
            else if (num == 8)
            {
                label2.Text = "Result: Eight";
            }
            else if (num == 9)
            {
                label2.Text = "Result: Nine";
            }
            else if (num == 10)
            {
                label2.Text = "Result: Ten";
            }
            else
            {
                label2.Text = "Invalid number";
            }
        }
    }
}
