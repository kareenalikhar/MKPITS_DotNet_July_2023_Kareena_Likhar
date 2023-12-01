using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_salary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Salary s=new Salary();
        private void button1_Click(object sender, EventArgs e)
        {
            s.sal(textBox1.Text, Convert.ToInt32(textBox2.Text), textBox3.Text);
            label4.Text=s.display();
        }
    }
}
