using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_array_class_student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Student[] stud=new Student[10];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            stud[0]= new Student();
            stud[1] = new Student();
            stud[2] = new Student();
            stud[3] = new Student();
            stud[4] = new Student();
            stud[5] = new Student();
            stud[6] = new Student();
            stud[7] = new Student();
            stud[8] = new Student();
            stud[9] = new Student();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<10)
            {
                stud[cnt].rollno=Convert.ToInt32(textBox1.Text);
                stud[cnt].name=textBox2.Text;
                stud[cnt].fees=Convert.ToDouble(textBox3.Text);
                stud[cnt].date = textBox4.Text;
                cnt++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
                if(cnt==10)
                {
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    button1.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("Click on Show student details");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Student's Details: \n");
            sb.Append("________________________________\n");
            for(int i = 0; i < 10;i++)
            {
                sb.Append("Student Roll no: " + stud[i].rollno + "\n");
                sb.Append("Student Name: " + stud[i].name + "\n");
                sb.Append("Student fees: " + stud[i].fees + "\n");
                sb.Append("Student fees Date: " + stud[i].date + "\n");
            }
            sb.Append("________________________________");
            label5.Text = sb.ToString();

            //code for highest fees

            double high = stud[0].fees;
            int foundat = 0;
            for (int i = 0; i < 10; i++)
            {

                if (high < stud[i].fees)
                {
                    high = stud[i].fees;
                    foundat = i;
                }

            }

            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Employee Details having Highest Salary :) \n");
            sb.Append("____________________________________________");
            sb1.Append("Student rollno: " + stud[foundat].rollno + "\n");
            sb1.Append("Student name: " + stud[foundat].name + "\n");
            sb1.Append("Student fees: " + stud[foundat].fees + "\n");
            sb1.Append("Student Addmission Date: " + stud[foundat].date + "\n");
            label6.Text = sb1.ToString();
        }
    }
}
