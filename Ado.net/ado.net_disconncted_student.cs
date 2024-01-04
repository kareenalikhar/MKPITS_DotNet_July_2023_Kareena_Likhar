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

namespace ado.net_disconncted_student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strcon = "server=HP\\SQLEXPRESS;integrated security=true;database=mkpsample";
        SqlConnection con = null;
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder cb = null;
        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(strcon);
            da = new SqlDataAdapter("select * from students ", con);
            cb = new SqlCommandBuilder(da);
            da.Fill(ds, "stud");
            dataGridView1.DataSource = ds.Tables["stud"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            da.Update(ds.Tables["stud"]);
            MessageBox.Show("Update succesfully");
        }
    }
}
