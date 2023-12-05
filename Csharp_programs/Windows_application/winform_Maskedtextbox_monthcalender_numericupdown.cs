﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_Maskedtextbox_monthcalender_numericupdown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = maskedTextBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text=monthCalendar1.SelectionStart.Date.ToShortDateString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = numericUpDown1.Text;
        }
    }
}
