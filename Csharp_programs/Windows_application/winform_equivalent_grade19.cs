//19. Write a program in C# Sharp to accept a grade and declare the equivalent description :

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_equivalent_grade19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char grade;
            grade = Convert.ToChar(textBox1.Text);
            if (grade == 'a')
            {
                label2.Text=("Result: Average");
            }
            else if (grade == 'e')
            {
                label2.Text=("Result: Excellent");
            }
            else if (grade == 'v')
            {
                label2.Text=("Result: Very Good");
            }
            else if (grade == 'g')
            {
                label2.Text=("Result: Good");
            }
            else if (grade == 'f')
            {
                label2.Text=("Result: Fail");
            }
        }
    }
}
