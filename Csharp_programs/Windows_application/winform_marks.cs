using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_marks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m, p, c;
            int total;
            float per;
            string grade = null;
            m = Convert.ToInt32(textBox1.Text);
            p = Convert.ToInt32(textBox2.Text);
            c = Convert.ToInt32(textBox3.Text);
            total = m + p + c;
            per = (total / 300.0f) * 100.0f;
            label4.Text = "total " + total;
            label5.Text = "percentage : " + per;
            if (per >= 75)
                grade = "distinction";
            else if (per >= 60 && per < 75)
                grade = "first";
            else if (per >= 40 && per < 60)
                grade = "second";
            else
                grade = "fail";

            label6.Text = "grade: " + grade;

        }
    }
}
