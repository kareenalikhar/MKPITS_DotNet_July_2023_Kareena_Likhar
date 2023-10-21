//9. Write a C# Sharp program to accept a coordinate point in an XY coordinate
//system and determine in which quadrant the coordinate point lies.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_quadrant9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x=Convert.ToInt32(textBox1.Text);
            int y=Convert.ToInt32(textBox2.Text);
            if (x > 0 && y > 0)
            {
                label3.Text = "Result: First Quadrant";
                    }
            else if (x < 0 && y > 0)
            {
                label3.Text = "Result: Second Quadrant";
            }
            else if (x < 0 && y < 0)
            {
                label3.Text = "Result: Third Quadrant";
            }
            else if (x > 0 && y < 0)
            {
                label3.Text = "Result: Fourth Quadrant";
            }
            else if (x == 0 && y == 0)
            {
                label3.Text = "Result: Origin";
            }
        }
    }
}
