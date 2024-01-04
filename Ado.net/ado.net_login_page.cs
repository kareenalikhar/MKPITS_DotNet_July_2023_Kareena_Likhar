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

namespace ado.net_login_page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strcon = "server=HP\\SQLEXPRESS;integrated security=true;database=mkpsample";
        SqlConnection con = null;
        SqlCommand command = null;

        private void button1_Click(object sender, EventArgs e)
        {
            con=new SqlConnection(strcon);
            string qr = "select count(*) from users where @username=username and @password=password";
            command = new SqlCommand(qr, con);

            command.Parameters.AddWithValue("@username", textBox1.Text);
            command.Parameters.AddWithValue("@password",textBox2.Text);
            con.Open();
            int cnt=Convert.ToInt32(command.ExecuteScalar());
            if(cnt>0)
            {
                label3.Text = "Login succesfully";
            }
            else
            {
                label3.Text = "Invalid Creadential,try again";
            }
            con.Close();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
