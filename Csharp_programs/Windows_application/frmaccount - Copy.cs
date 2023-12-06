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
    public partial class frmaccount : Form
    {
        public frmaccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 1000;
            StringBuilder sb= new StringBuilder();
            sb.Append("Account no: " + Convert.ToInt32(textBox1.Text)+"\n");
            int amt=Convert.ToInt32(textBox2.Text);
            sb.Append("Amount : " + amt+"\n");
            if(radioButton1.Checked)
            {
                bal = bal + amt;
                sb.Append("Balance after deposit: " + bal);
            }
            else if(radioButton2.Checked)
            {
                if (amt > bal)
                {
                    MessageBox.Show("Insufficient Amount in account:");
                }
                else
                {
                    bal = bal - amt;
                    sb.Append("Balance after withdrawl: " + bal);
                }
            }
            
            label5.Text= sb.ToString();
        }
    }
}
