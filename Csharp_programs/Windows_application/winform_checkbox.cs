using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_checkbox
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
        string name;
        int sal;
        float bonus, tsal;
        string designation;
        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            sal=Convert.ToInt32(textBox2.Text);
            StringBuilder sb = new StringBuilder();
            bonus = sal * 0.45f;
            tsal = bonus + sal;
            if (checkBox1.Checked && checkBox2.Checked)
            {
                sb.Append("Name: " + name+"\n");
                sb.Append("Bonus: " + bonus+"\n");
                sb.Append("Total: " + tsal);
            }
             else if (checkBox1.Checked ) 
            {
                sb.Append("Name: " + name+ "\n");
                sb.Append("Bonus: " + bonus);
            }
            else if(checkBox2.Checked )
            {
                sb.Append("Name: " + name+"\n");
                sb.Append("Total: " + tsal);
            }
            label3.Text = sb.ToString();
        }
    }
}
