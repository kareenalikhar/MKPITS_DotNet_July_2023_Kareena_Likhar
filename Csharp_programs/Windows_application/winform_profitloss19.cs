//17. Write a C# Sharp program to calculate profit and loss on a transaction.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_profitloss17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sp, cp, result, result1;
            sp = Convert.ToInt32(textBox1.Text);
            cp = Convert.ToInt32(textBox2.Text);
            result = sp - cp;
            result1 = cp - sp;
            if (sp > cp)
            {
                label3.Text=("Your Profit amount : " + result);
            }
            else
            {
                label3.Text=("Your Loss amount : " + result1);
            }
        }
    }
}
