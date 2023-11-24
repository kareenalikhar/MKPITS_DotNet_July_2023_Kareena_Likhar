using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace winform_collection_stack_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack s = new Stack();
        private void button1_Click(object sender, EventArgs e)
        {
            s.Push(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();
            foreach(string sl in s)
            {
                sb.Append(sl + "\n");
            }
            label2.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb1= new StringBuilder();
            sb1.Append("The next poppable value in stack: " + s.Peek() + "\n");
            sb1.Append("After Pop: \n");
            s.Pop();
            foreach(string sl1 in s)
            {
                sb1.Append(sl1 + "\n");
            }
            label2.Text= sb1.ToString();
        }
    }
}
