using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_circle_properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circle c = new Circle();
            c.radius = Convert.ToInt32(textBox1.Text);
            c.getdata(c.radius);
            StringBuilder sb = new StringBuilder();
            sb.Append("Area of Circle : " + c.area + "\n");
            sb.Append("Circumference of Circle : " + c.circ + "\n");
            label2.Text = sb.ToString();
        }
    }
}
