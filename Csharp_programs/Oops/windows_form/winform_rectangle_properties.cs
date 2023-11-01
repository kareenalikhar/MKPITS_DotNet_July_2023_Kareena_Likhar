using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_rectangle_properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.width = Convert.ToInt32(textBox1.Text);
            rect.height = Convert.ToInt32(textBox2.Text);

            StringBuilder sb = new StringBuilder();
            rect.getdata(rect.width, rect.height);
            sb.Append("Area of Rectangle: " + rect.area);
            label3.Text = sb.ToString();
        }
    }
}
