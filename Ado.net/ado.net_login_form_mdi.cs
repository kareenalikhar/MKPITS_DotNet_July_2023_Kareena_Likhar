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
            string str = "select count(*) from users where @username=username and @password=password";
            command= new SqlCommand(str, con);
            command.Parameters.AddWithValue("@username", textBox1.Text);
            command.Parameters.AddWithValue("@password", textBox2.Text);

            con.Open();
            int cnt=Convert.ToInt32(command.ExecuteScalar());
            if(cnt>0)
            {
                MessageBox.Show("Login Succesfully");
            }
            else
            {
                MessageBox.Show("Invalid Credential,try again");
            }
            con.Close();

            panel1.Visible = false;
            menuStrip1.Visible = true;
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Products p=new Products();
            p.Show();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer cust=new Customer();
            cust.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
