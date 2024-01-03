using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_class_sqlcon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentClass s=new StudentClass();
            string gender=null;
            if(radioButton1.Checked)
            {
                gender=radioButton1.Text;
            }
            if(radioButton2.Checked)
            {
                gender=radioButton2.Text;
            }

            string hobby=null;
            if(checkBox1.Checked)
            {
                hobby=checkBox1.Text;
            }
            if(checkBox2.Checked)
            {
                if(checkBox1.Checked)
                {
                    hobby= checkBox1.Text + ","+ checkBox2.Text;
                }
                else
                {
                    hobby=checkBox2.Text;
                }
            }
            string result = s.InsertStudent(Convert.ToInt32(textBox1.Text), textBox2.Text, gender, hobby, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());

            label7.Text= result;
            clear();
        }

        public void clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked= false;
            radioButton2.Checked= false;
            checkBox1.Checked= false;
            checkBox2.Checked= false;
            comboBox1.Text = "";
            dateTimePicker1.Text = DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentClass s=new StudentClass();

            string gender = null;
            if(radioButton1.Checked)
            {
                gender=radioButton1.Text;
            }
            if(radioButton2.Checked)
            {
                gender=radioButton2.Text;
            }

            string hobby = null;
            if (checkBox1.Checked)
            {
                hobby = checkBox1.Text;
            }
            if(checkBox2.Checked)
            {
                if(checkBox1.Checked)
                {
                    hobby=checkBox1.Text+ ","+checkBox2.Text;
                }
                else
                {
                    hobby=checkBox2.Text;
                }
            }

            string result = s.UpdateStudent(Convert.ToInt32(textBox1.Text), textBox2.Text, gender, hobby, comboBox1.Text, dateTimePicker1.Text); 

            label7.Text = result;
            clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StudentClass s=new StudentClass();

            string gender = null;
            if(radioButton1.Checked)
            {
                gender=radioButton1.Text;
            }
            if(radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
            string hobby = null;
            if (checkBox1.Checked)
            {
                hobby = checkBox1.Text;
            }
            if(checkBox2.Checked)
            {
                if(checkBox1.Checked)
                {
                    hobby=checkBox1.Text+ ","+checkBox2.Text;   
                }
                else
                {
                    hobby=checkBox2.Text;
                }
            }            
            string result=s.DeleteStudent(Convert.ToInt32(textBox1.Text),textBox2.Text,gender, hobby, comboBox1.Text,dateTimePicker1.Text);
            label7.Text = result;
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<student> li=new List<student>();
            StudentClass s = new StudentClass();
            li = s.SearchStudent(Convert.ToInt32(textBox1.Text));

            textBox2.Text = li[0].studname;

            string g = li[0].gender;
            if(g=="Male")
            {
                radioButton1.Checked= true;
            }
            else if(g=="Female")
            {
                radioButton2.Checked= true;
            }

            string h = li[0].hobby;
            if(h=="Reading")
            {
                checkBox1.Checked= true;
            }
            if(h=="Travelling")
            {              
                    checkBox2.Checked = true;
            }
            if(h=="Reading" && h=="Travelling")
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
            }
            
            comboBox1.Text = li[0].city;
            dateTimePicker1.Text = li[0].dob;             
        }
    }
}
