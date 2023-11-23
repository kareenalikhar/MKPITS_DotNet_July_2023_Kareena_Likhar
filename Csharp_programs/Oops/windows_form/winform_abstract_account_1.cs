using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_abstract_account_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account act = null;
            int actno=Convert.ToInt32(textBox1.Text);
            int amt=Convert.ToInt32(textBox2.Text);

            if(radioButton1.Checked)
            {
                act = new Current();
            }
            else if(radioButton2.Checked)
            {
                act = new Saving();
            }

            label4.Text=act.deposit(actno, amt);
            label5.Text = act.showbalance();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Account act = null;
            int actno = Convert.ToInt32(textBox1.Text);
            int amt = Convert.ToInt32(textBox2.Text);

            if (radioButton1.Checked)
            {
                act = new Current();
            }
            else if (radioButton2.Checked)
            {
                act = new Saving();
            }

            label4.Text = act.withdraw(actno, amt);
            label5.Text = act.showbalance();
        }
    }
}
