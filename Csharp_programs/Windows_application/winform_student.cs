﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string name = textBox1.Text;
            string age = numericUpDown1.Text;
            

            if(textBox1.Text=="")
            {
                MessageBox.Show("Enter Name and age");
            }
            
            if (numericUpDown1.Value < 18)
            {
                MessageBox.Show("The age is between 18 and 99");
            }
            else
            {
                sb.Append("Student Name: " + name + "\n");
                sb.Append("Student Age:" + age);
            }
            label3.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            numericUpDown1.Value = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome");
        }
    }
}
