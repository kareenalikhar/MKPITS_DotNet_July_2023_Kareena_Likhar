using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_bank_customer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bankcust b = new Bankcust();
            b.AccountNo = Convert.ToInt32(textBox1.Text);
            b.Name = textBox2.Text;
            b.Amount = Convert.ToInt32(textBox3.Text);
            b.getdata(b.AccountNo, b.Name, b.Amount);
            StringBuilder sb = new StringBuilder();
            sb.Append("After Deposite Amount is : " + b.deposite + "\n");
            sb.Append("After Withdrawl Amount is : " + b.withdrawl + "\n");
            label4.Text = sb.ToString();
        }
    }
}
