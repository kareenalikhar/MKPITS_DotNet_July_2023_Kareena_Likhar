//12. Write a C# Sharp program to read roll no, name and marks of three
//subjects and calculate the total, percentage and division.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_marksheet12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sub1, sub2, sub3, total;
            float per;
            string grade;
            
            sub1 = Convert.ToInt32(textBox1.Text);
            sub2 = Convert.ToInt32(textBox2.Text);
            sub3 = Convert.ToInt32(textBox3.Text);
            total = sub1 + sub2 + sub3;
            label4.Text = "Total: " + total;
            per = (total / 300.0f) * 100.0f;
            label5.Text = "Percentage: " + per;
            if (per >= 75)
            {
                grade = "Distinction";
            }
            else if (per >= 60 && per < 75)
            {
                grade = "First";
            }
            else
            {
                grade = "Fail";
            }
            label6.Text = "Grade: " + grade;
        }
    }
}
