//16. Write a C# Sharp program to check whether an alphabet letter is a vowel or a consonant.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_vowel16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char ch;
            ch = Convert.ToChar(textBox1.Text);
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                label2.Text=("Result: It is vowel");
            }
            else
            {
                label2.Text=("Result: It is Consonant");
            }
        }
    }
}
