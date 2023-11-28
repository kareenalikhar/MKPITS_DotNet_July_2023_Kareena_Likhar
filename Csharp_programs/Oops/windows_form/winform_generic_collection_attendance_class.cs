using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_generic_collection_attendance_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        Dictionary<int,Attendance> a=new Dictionary<int,Attendance>();
        private void button1_Click(object sender, EventArgs e)
        {
            Attendance att=new Attendance(Convert.ToInt32(textBox1.Text),textBox2.Text,Convert.ToInt32(textBox3.Text),textBox4.Text);
            a.Add(Convert.ToInt32(textBox1.Text),att);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int totalp = 0;
            int totala = 0;
            StringBuilder sb= new StringBuilder();

            foreach(KeyValuePair<int,Attendance> k in a)
            {
                if(k.Value.att=="a")
                {
                    totala++;
                }
                if(k.Value.att=="p")
                {
                    totalp++;
                }

                sb.Append("Student Roll no: " + k.Key + "\n");
                sb.Append("Student name: "+k.Value.name+"\n");
                sb.Append("Student Attendance date: "+k.Value.attdate+"\n");
                sb.Append("Student Attendance(a or p): " + k.Value.att + "\n");

                sb.Append("___________________________________________\n");
                sb.Append("Student total present: "+totalp +"\n");
                sb.Append("Student total absent: "+totala+"\n");
                sb.Append("___________________________________________\n");

            }
            label5.Text = sb.ToString();
        }
    }
}
