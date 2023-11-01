using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_student_array_properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student stud = new Student();
            stud.Name =textBox5.Text;
            stud.RollNo=Convert.ToInt32(textBox4.Text);
            stud.Submarks[0]=Convert.ToInt32(textBox1.Text);
            stud.Submarks[1] = Convert.ToInt32(textBox2.Text);
            stud.Submarks[2] = Convert.ToInt32(textBox3.Text);
            

            StringBuilder sb = new StringBuilder();
            stud.getdata(stud.Name,stud.RollNo,stud.Submarks);
            sb.Append("Name:" + stud.Name);
            sb.Append("\nRoll no: " + stud.RollNo);
            sb.Append("\nTotal: "+stud.total);
            sb.Append("\nAverage: " + stud.Average);
            label4.Text = sb.ToString();


        }
    }
}
