using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace employee_sql_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            string str = "server=HP\\SQLEXPRESS;integrated security=true;database=empsample";
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                string strcmd = "insert into employee values('" + textBox1.Text + "','" + textBox2.Text + "','" + richTextBox1.Text + "','" + textBox3.Text + "','" + gender + "','" + comboBox1.Text + "')";
                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label7.Text = "Record inserted successfully";

                textBox1.Clear();
                textBox2.Clear();
                richTextBox1.Clear();
                textBox3.Clear();
                comboBox1.Items.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            string str = "server=HP\\SQLEXPRESS;integrated security=true;database=empsample";
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                string strcmd = "UPDATE employee SET Empid='" + textBox1.Text + "', address='" + richTextBox1.Text + "', Contact='" + textBox3.Text + "', gender='" + gender + "', city='" + comboBox1.Text + "' WHERE empname = '" + textBox2.Text + "'";
                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label7.Text = "Record Updated successfully";

                textBox1.Clear();
                textBox2.Clear();
                richTextBox1.Clear();
                textBox3.Clear();
                comboBox1.Items.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            string str = "server=HP\\SQLEXPRESS;integrated security=true;database=empsample";
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                string strcmd = "delete from employee where Empid='" + textBox1.Text + "' ";
                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label7.Text = "Record Updated successfully";

                textBox1.Clear();
                textBox2.Clear();
                richTextBox1.Clear();
                textBox3.Clear();
                comboBox1.Text = string.Empty;
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            string str = "server=HP\\SQLEXPRESS;integrated security=true;database=empsample";
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                string strcmd = "select * from employee where Empid='" + textBox1.Text + "' ";
                SqlCommand command = new SqlCommand(strcmd, con);
                SqlDataReader dr;
                int flag = 0;
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["empname"].ToString();
                    textBox3.Text = dr["contact"].ToString();
                    richTextBox1.Text = dr["address"].ToString();
                    comboBox1.Text = dr["city"].ToString();
                    gender = dr["gender"].ToString();
                    radioButton1.Checked = (gender == "Male"); 
                    radioButton2.Checked = (gender == "Female");

                }
                dr.Close();
                con.Close();
                if (flag == 0)
                {
                    label7.Text = "Record not found";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
