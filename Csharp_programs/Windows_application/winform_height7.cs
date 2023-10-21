//7. Write a C# Sharp program to accept a person's height in centimeters and
//categorize them according to their height.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_height7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int h=Convert.ToInt32(textBox1.Text);
            if(h>=145)
            {
                label2.Text = "Result: Tall";
            }
            else
            {
                label2.Text = "Result: Dwarf";
            }
        }
    }
}
