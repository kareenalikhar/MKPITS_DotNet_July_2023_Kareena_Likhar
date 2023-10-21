//10. Write a C# Sharp program to determine the eligibility for admission
//to a professional course based on the following criteria:

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_addmision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int maths=Convert.ToInt32(textBox1.Text);
            int phy=Convert.ToInt32(textBox2.Text);
            int chem=Convert.ToInt32(textBox3.Text);
            int total=maths+phy+chem;
            label4.Text = "Total Marks: "+total;
            if (maths >= 65 && phy >= 55 && chem >= 50 && total >= 140)
            {
                label5.Text="The candidate is eligible for admission.";
            }
            else
            {
                label5.Text="The candidate is not eligible for admission.";
            }
        }
    }
}
