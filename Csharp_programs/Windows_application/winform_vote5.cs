//5. Write a C# Sharp program to read the age of a candidate and
//determine whether it is eligible for casting his/her own vote.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_vote5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age=Convert.ToInt32(textBox1.Text);
            if(age>=18)
            {
                label2.Text = "Result: The person is eligible for vote:";
            }
            else
            {
                label2.Text = "Result: The person is not eligible for vote:";
            }
        }
    }
}
