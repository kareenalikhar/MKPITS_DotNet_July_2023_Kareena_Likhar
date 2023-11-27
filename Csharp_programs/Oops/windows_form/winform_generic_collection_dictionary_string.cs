using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_generic_collection_dictionary_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<string, string> li=new Dictionary<string, string>();
        private void button1_Click(object sender, EventArgs e)
        {
            li.Add(textBox1.Text,textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();
            List<string> key = new List<string>(li.Keys);
            foreach (string k in key)
            {
                sb.Append(k + "\n");
            }
            label3.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb1= new StringBuilder();
            List<string> value=new List<string>(li.Values);
            foreach(string k in value)
            {
                sb1.Append(k + "\n");
            }
            label3.Text= sb1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb2= new StringBuilder();
            foreach(KeyValuePair<string,string> kvp in li)
            {
                sb2.Append(kvp.Key + " : "+ kvp.Value + "\n");
            }
            label3.Text=sb2.ToString();
        }
    }
}
