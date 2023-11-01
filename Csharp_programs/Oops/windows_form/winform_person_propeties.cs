using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_person_properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            person per=new person();
            per.Name=textBox1.Text;
            per.Age=Convert.ToInt32(textBox2.Text);
            per.Address=textBox3.Text;

            StringBuilder sb=new StringBuilder();
            sb.Append("Name: " + per.Name + "\n");
            sb.Append("Age: " + per.Age + "\n");
            sb.Append("Address: " + per.Address + "\n");
            label4.Text=sb.ToString();
        }
    }
}
