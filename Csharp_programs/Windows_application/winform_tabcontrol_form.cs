using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_tabcontrol_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb=new StringBuilder();
            sb.Append("Name: " + textBox1.Text+"\n");
            sb.Append("Date of birth: " + maskedTextBox1.Text+"\n");
            sb.Append("Nationality: " + textBox2.Text + "\n");
            sb.Append("City: " + textBox3.Text + "\n");
            sb.Append("Qualification: " + textBox4.Text + "\n");
            sb.Append("Email id: "+textBox5.Text + "\n");
            sb.Append("Address: "+textBox6.Text+ "\n");
            label7.Text = sb.ToString();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("First Name: "+textBox7.Text+"\n");
            sb.Append("Surname: "+textBox8.Text+"\n");
            sb.Append("Father name: "+textBox9.Text+"\n");
            sb.Append("Mother Name: "+textBox10.Text+"\n");
            sb.Append("Courses: "+comboBox1.Text+"\n");
            sb.Append("Date of Birth: "+maskedTextBox2.Text+"\n");
            sb.Append("Qualification: "+textBox13.Text+"\n");
            string gender = null;
            if(radioButton1.Checked)
            {
                gender= radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                gender= radioButton2.Text;
            }
            else if(radioButton3.Checked)
            {
                gender= radioButton3.Text;
            }
            sb.Append("Gender: " + gender);
            sb.Append("Address: "+richTextBox1.Text+"\n");
            label22.Text = sb.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {























        }
    }
}
