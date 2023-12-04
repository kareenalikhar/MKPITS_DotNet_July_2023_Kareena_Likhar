using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_registration_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();
            sb.Append("Username: " + textBox1.Text +"\n");
            sb.Append("Password: " + textBox2.Text+"\n");
            if(radioButton1.Checked)
            {
                sb.Append("Gender: " + radioButton1.Text + "\n");
            }
            else if(radioButton2.Checked)
            {
                sb.Append("Gender: " + radioButton2.Text+"\n");
            }

            if(checkBox1.Checked && checkBox2.Checked)
            {
                sb.Append("Courses: " + checkBox1.Text+ " and "+checkBox2.Text +"\n");

            }
            else if(checkBox1.Checked)
            {
                sb.Append("Courses: " + checkBox1.Text + "\n");
            }
            else if(checkBox2.Checked)
            {
                sb.Append("Courses: " + checkBox2.Text + "\n");
            }

            sb.Append("City: " + comboBox1.Text+ "\n");
            label6.Text= sb.ToString();
        }
    }
}
