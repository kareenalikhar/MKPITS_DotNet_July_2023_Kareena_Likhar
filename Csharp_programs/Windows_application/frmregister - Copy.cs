using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_mdiform
{
    public partial class frmregister : Form
    {
        public frmregister()
        {
            InitializeComponent();
        }

        private void frmregister_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Please enter details::");
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("Name: " + textBox1.Text + "\n");
                sb.Append("Email id: " + textBox2.Text + "\n");
                sb.Append("Age: " + Convert.ToInt32(textBox3.Text) + "\n");
                string gender = null;
                if(radioButton1.Checked)
                {
                    gender= radioButton1.Text;
                }
                else if(radioButton2.Checked)
                {
                    gender = radioButton2.Text;
                }
                sb.Append("Gender: " + gender + "\n");

                string course = null;
                if(checkBox1.Checked)
                {
                    course=checkBox1.Text;
                }
                if(checkBox2.Checked)
                {
                    course = course +" " +checkBox2.Text;
                }
                sb.Append("Couses: "+course+"\n");
                sb.Append("City: " + comboBox1.Text);

                label8.Text=sb.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.Enabled= false;
        }
    }
}
