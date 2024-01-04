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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        public void cleartext()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string strcon = "server=HP\\SQLEXPRESS;integrated security=true;database=mkpsample";
            SqlConnection con=new SqlConnection(strcon);
            con.Open();

            string str = "insert into products values (@prodid,@prodname,@price,@quantity)";

            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@prodid", textBox1.Text);
            command.Parameters.AddWithValue("@prodname",textBox2.Text);
            command.Parameters.AddWithValue("@price",textBox3.Text);
            command.Parameters.AddWithValue("@quantity", textBox4.Text);
            command.ExecuteNonQuery();
            con.Close();
            label5.Text = "Inserted Succesfully";
            cleartext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strcon = "server=HP\\SQLEXPRESS;integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string str = "update products set prodname=@prodname,price=@price,quantity=@quantity where prodid=@prodid";
            SqlCommand command = new SqlCommand(str, con);
            command.Parameters.AddWithValue("@prodname", textBox2.Text);
            command.Parameters.AddWithValue("@price", textBox3.Text);
            command.Parameters.AddWithValue("@quantity", textBox4.Text);
            command.Parameters.AddWithValue("@prodid", textBox1.Text);
            command.ExecuteNonQuery();
            con.Close();
            label5.Text = "Updated Succesfully";
            cleartext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strcon = "server=HP\\SQLEXPRESS;integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string str = "delete from products where prodid=@prodid";
            SqlCommand command = new SqlCommand(str, con);    
            command.Parameters.AddWithValue("@prodid", textBox1.Text);
            command.ExecuteNonQuery();
            con.Close();
            label5.Text = "Deleted Succesfully";
            cleartext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strcon = "server=HP\\SQLEXPRESS;integrated security=true;database=mkpsample";
            SqlConnection con = new SqlConnection( strcon);
            con.Open();
            string str = "select * from products where prodid=@prodid";
            SqlCommand command =new SqlCommand(str, con);
            command.Parameters.AddWithValue("@prodid", textBox1.Text);

            SqlDataReader dr;
            int flag = 0;
            dr=command.ExecuteReader();

            while(dr.Read())
            {
                flag = 1;
                textBox2.Text = dr["prodname"].ToString();
                textBox3.Text = dr["price"].ToString();
                textBox4.Text = dr["quantity"].ToString();
            }
            dr.Close();
            con.Close();
            if(flag == 0 )
            {
                label5.Text = "Record not found";
            }
            else
            {
                label5.Text = "Record found successfully";
            }
        }
    }
}
