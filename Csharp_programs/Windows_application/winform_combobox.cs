using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace winform_combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name;
        int sal;
        float bonus, tsal;
        string designation;
        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            sal = Convert.ToInt32(textBox2.Text);
            StringBuilder sb = new StringBuilder();
            if (comboBox1.Text == "manager")
            {
                bonus = sal * 0.45f;
            }
            else if (comboBox1.Text == "clerk")
            {
                bonus = sal * 0.25f;
            }
            else if (comboBox1.Text == "peon")
            {
                bonus = sal * 0.15f;
            }

            tsal = sal + bonus; 

            if (checkBox1.Checked && checkBox2.Checked)
            {
                sb.Append("Name: " + name + "\n");
                sb.Append("Bonus: " + bonus + "\n");
                sb.Append("Total: " + tsal);
            }
            else if (checkBox1.Checked)
            {
                sb.Append("Name: " + name + "\n");
                sb.Append("Bonus: " + bonus);
            }
            else if (checkBox2.Checked)
            {
                sb.Append("Name: " + name + "\n");
                sb.Append("Total: " + tsal);
            }
            label3.Text = sb.ToString();
        }
    }
}
