using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado.net_login_form_mdi
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        public void cleartext()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string strcon = "server=HP\\SQLEXPRESS;integrated security=true;database=mkpsample";
            SqlConnection con=new SqlConnection(strcon);
            con.Open();
            string str = "insert into customer values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            SqlCommand command=new SqlCommand(str, con);
            command.ExecuteNonQuery();
            con.Close();
            label6.Text = "Inserted succesfully";
            cleartext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strcon = "server=HP\\SQLEXPRESS;integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string str = "update customer set custname='" + textBox2.Text + "',custaddress='" + textBox3.Text + "',mobileno='" + textBox4.Text + "',emailid='" + textBox5.Text + "' where custid='" + textBox1.Text + "'";
            SqlCommand command = new SqlCommand(str, con);
            command.ExecuteNonQuery();
            con.Close();
            label6.Text = "Updated succesfully";
            cleartext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strcon = "server=HP\\SQLEXPRESS;integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string str = "delete from customer where custid='" + textBox1.Text + "'";
            SqlCommand command = new SqlCommand(str, con);
            command.ExecuteNonQuery();
            con.Close();
            label6.Text = "Deleted succesfully";
            cleartext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strcon = "server=HP\\SQLEXPRESS;integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string str = "select * from customer where custid='" + textBox1.Text + "'";
            SqlCommand command= new SqlCommand(str, con);   

            SqlDataReader dr;
            int flag = 0;
            dr = command.ExecuteReader();
            while (dr.Read()) 
            {
                flag = 1;
                textBox2.Text = dr["custname"].ToString();
                textBox3.Text = dr["custaddress"].ToString();
                textBox4.Text = dr["mobileno"].ToString();
                textBox5.Text = dr["emailid"].ToString();
            }
            dr.Close();
            con.Close();
            if (flag == 0)
            {
                label6.Text = "Record not found";
            }
            else
            {
                label6.Text = "Record found successfully";
            }

        }
    }
}
