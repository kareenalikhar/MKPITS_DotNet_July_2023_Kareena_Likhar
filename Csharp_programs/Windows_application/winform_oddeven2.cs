using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_odd_even2
{
    public partial class Form1 : Form
    {
//2. Write a C# Sharp program to check whether a given number is even or odd.
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num=Convert.ToInt32(textBox1.Text);
            if(num%2==0 )
            {
                label2.Text = "Result: It is even:)";
            }
            else
            {
                label2.Text = "Result: It is odd:)";
            }
        }
    }
}
