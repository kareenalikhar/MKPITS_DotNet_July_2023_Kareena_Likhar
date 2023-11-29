using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using banklibrary;

namespace usingbankdll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bank act=null;

        private void button1_Click(object sender, EventArgs e)
        {
            act.actno=(Convert.ToInt32(textBox1.Text));
            string res = act.deposit(Convert.ToInt32(textBox2.Text));
            label4.Text = res;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            act.actno=(Convert.ToInt32(textBox1.Text));
            string res=act.withdrawl(Convert.ToInt32(textBox2.Text));
            label4.Text = res;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Saving")
            {
                act = new saving();
            }
            else if(comboBox1.Text=="Current")
            {
                act=new current();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            act.actno=(Convert.ToInt32(textBox1.Text));
            string res = act.showbalance();
            label4.Text = res;
        }
    }
}
