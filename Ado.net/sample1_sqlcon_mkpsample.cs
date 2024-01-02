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

namespace sample1
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
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(str);
                con.Open();
                MessageBox.Show("Connected successfully");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}
