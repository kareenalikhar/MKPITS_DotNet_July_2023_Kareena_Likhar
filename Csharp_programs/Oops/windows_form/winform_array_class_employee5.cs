using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_array_class_employee5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Employee[] emp = new Employee[3];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            emp[0] = new Employee();
            emp[1] = new Employee();
            emp[2] = new Employee();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 3)
            {
                emp[cnt].empid = Convert.ToInt32(textBox1.Text);
                emp[cnt].name = textBox2.Text;
                emp[cnt].salary = Convert.ToDouble(textBox3.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox1.Focus();
                if (cnt == 3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("Click on Show employee button :)");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb =new StringBuilder();
            sb.Append("Employee Details:\n");
            for(int i = 0; i < 3; i++)
            {
                sb.Append("----------------------------------\n");
                sb.Append("Employee Id: " + emp[i].empid + "\n");
                sb.Append("Employee Name: " + emp[i].name + "\n");
                sb.Append("Employee Salary: " + emp[i].salary + "\n");
                sb.Append("----------------------------------\n");
            }
            label4.Text = sb.ToString();

            //code to find highest salary
            double high = emp[0].salary;
            int foundat = 0;
            for(int i = 0;i< 3;i++)
            {
                
                    if (high < emp[i].salary)
                    {
                        high = emp[i].salary;
                        foundat = i;
                    }
                
            }

            StringBuilder sb1= new StringBuilder();
            sb1.Append("Employee Details having Highest Salary :) \n");
            sb.Append("____________________________________________");
            sb1.Append("Employee id: " + emp[foundat].empid + "\n");
            sb1.Append("Employee name: " + emp[foundat].name + "\n");
            sb1.Append("Employee salary: " + emp[foundat].salary + "\n");
            label5.Text = sb1.ToString();
        }
    }
}

        
        