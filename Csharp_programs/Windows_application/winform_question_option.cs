using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_question_oprion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();
            int cnt = 0;
            if(radioButton1.Checked)
            {
                cnt++; ;
            }
            else
            {
                
            }

            if(radioButton5.Checked)
            {
                cnt++;
            }
            else
            {
                
            }

            if(radioButton9.Checked)
            {
                cnt++;
            }
            else
            {
                
            }
            sb.Append("Score: "+cnt.ToString());
            label2.Text = sb.ToString();
        }
    }
}
