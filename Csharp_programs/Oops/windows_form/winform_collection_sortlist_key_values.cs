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

namespace winform_collection_sortlist_key_values
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SortedList sl=new SortedList();
        private void button1_Click(object sender, EventArgs e)
        {
            sl.Add(Convert.ToInt32(textBox1.Text), textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ICollection key=sl.Keys;
            StringBuilder sb=new StringBuilder();
            foreach (int i in key)
            {
                sb.Append(i +" : "+ sl[i]+ "\n");
            }
            label3.Text = sb.ToString();
        }
    }
}
