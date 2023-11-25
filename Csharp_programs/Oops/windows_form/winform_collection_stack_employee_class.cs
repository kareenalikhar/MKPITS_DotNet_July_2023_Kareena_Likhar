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

namespace winform_collection_stack_employee_class
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        Employee emp;
        Stack s = new Stack();
        private void button1_Click(object sender, EventArgs e)
        {
            emp=new Employee (Convert.ToInt16(textBox1.Text),textBox2.Text,Convert.ToInt32(textBox3.Text),textBox4.Text);
            s.Push(emp);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Employee emp1 in s)
            {
                sb.Append(emp1.empno + " : " + emp1.name + " : " + emp1.salary + " : " + emp1.designation+ "\n"); 
            }
            label5.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee r=(Employee)s.Pop();
            StringBuilder sb1= new StringBuilder();
            sb1.Append("Item push: " + r.empno + " : " + r.name + " : " + r.salary + " : " + r.designation + "\n"); 

            sb1.Append("After push: \n");
            foreach (Employee emp3 in s)
            {
                sb1.Append(emp3.empno + " : " + emp3.name + " : " + emp3.salary + " : " + emp3.designation + "\n");
            }
            label5.Text= sb1.ToString();
        }
    }
}
