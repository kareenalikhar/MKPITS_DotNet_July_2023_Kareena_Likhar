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

namespace winform_collection_queue_student_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student s;
        Queue q = new Queue();

        private void button1_Click(object sender, EventArgs e)
        {
            s = new Student(Convert.ToInt32(textBox1.Text),textBox2.Text);
            q.Enqueue(s);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        

            StringBuilder sb= new StringBuilder();
            foreach(Student stud in q)
            {
                sb.Append(stud.rno + " : " + stud.name + "\n");
            }
            label3.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student r=(Student)q.Dequeue();
            StringBuilder sb1= new StringBuilder();
            sb1.Append("Item dequeue: " + r.rno + " : " + r.name+ "\n");
            sb1.Append("After Dequeue: \n");
            foreach(Student stud1 in q)
            {
                sb1.Append(stud1.rno + " : " + stud1.name + "\n");
            }
            label3.Text= sb1.ToString();
        }
    }
}
