using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int actno;
            int bal = 1000;
            actno = Convert.ToInt32(textBox1.Text);
            StringBuilder sb=   new StringBuilder();
            if(radioButton1.Checked )
            {
                bal = bal + Convert.ToInt32(textBox2.Text);
            }
            else if(radioButton2.Checked )
            {
                bal=bal-Convert.ToInt32(textBox2.Text);
            }
            sb.Append("Account no: " + actno + "\n" + "Balance: " + bal + "\n");
            label3.Text = sb.ToString();
        }
    }
}
