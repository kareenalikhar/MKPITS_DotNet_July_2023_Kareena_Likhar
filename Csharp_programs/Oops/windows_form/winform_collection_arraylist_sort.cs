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

namespace winform_collection_arraylist_sort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ArrayList ar=new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            ar.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Name after sorting");
            ar.Sort();
            StringBuilder sb = new StringBuilder();
            foreach(object o in ar)
            {
                sb.Append("Name: " + o +"\n");
            }
            label2.Text = sb.ToString();
        }
    }
}
