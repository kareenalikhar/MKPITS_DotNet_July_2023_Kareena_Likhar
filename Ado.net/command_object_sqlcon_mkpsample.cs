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

namespace command_object_sql_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "server=HP\\SQLEXPRESS;integrated security=true;database=mkpsample";
            SqlConnection con=new SqlConnection(str);

            try
            {
                con.Open();
                string strcmd = "insert into users values('" + textBox1.Text + "','" + textBox2.Text + "')";
                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();

                label3.Text = "Inserted Succesfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = "server=HP\\SQLEXPRESS;integrated security=true;database=mkpsample";
            SqlConnection con =new SqlConnection(str);

            try
            {
                con.Open();
                string strcmd = "update users set password='" + textBox2.Text + "' where username='" + textBox1.Text + "'";
                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();

                label3.Text = "Updated successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = "server=HP\\SQLEXPRESS;integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection(str);

            try
            {
                con.Open();
                string strcmd = "delete from users where username='" + textBox1.Text + "'or password='" + textBox2.Text + "'";
                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery(); 
                con.Close();
                label3.Text = "Deleted successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = "server=HP\\SQLEXPRESS;integrated security=true;database=mkpsample";
            SqlConnection con=new SqlConnection(str);

            try
            {
                con.Open();
                string strcmd = "select * from users where username='" + textBox1.Text + "'";
                SqlCommand command = new SqlCommand(strcmd, con);

                SqlDataReader dr;
                int flag = 0;

                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["password"].ToString();
                }
                dr.Close();
                con.Close();
                if(flag==0)
                {
                    label3.Text = "record not found";
                }
                else
                {
                    label3.Text = "Record found successfully";
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}
