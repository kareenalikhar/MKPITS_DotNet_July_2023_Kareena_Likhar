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

namespace ado.net_course_registration
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string strcon = "server=HP\\SQLEXPRESS;integrated security=true;database=Course_Reg;";
        SqlConnection con = null;
        SqlDataAdapter da = null;
        DataSet ds;
        private void Form1_Load(object sender, EventArgs e)
        {
            getnation();
            getstate();
            getcity();

            if(radioButton1.Checked)
            {
                textBox2.Text = "1000";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getstate();
            
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getcity();
        }

        public void getnation()
        {
            try
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from tablenation order by nationid", con);
                ds = new DataSet();
                da.Fill(ds, "tablenation");
                comboBox1.DataSource = ds.Tables["tablenation"];
                comboBox1.DisplayMember = "nationname";
                comboBox1.ValueMember = "nationid";
            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
        public void getstate()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from tablestate where nationid=@nationid", con);
                    da.SelectCommand.Parameters.AddWithValue("@nationid", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "tablestate");
                    comboBox2.DataSource = ds.Tables["tablestate"];
                    comboBox2.DisplayMember = "statename";
                    comboBox2.ValueMember = "stateid";
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        public void getcity()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {

                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from tablecity where stateid=@stateid", con);
                    da.SelectCommand.Parameters.AddWithValue("@stateid", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "tablecity");
                    comboBox3.DataSource = ds.Tables["tablecity"];
                    comboBox3.DisplayMember = "cityname";
                    comboBox3.ValueMember = "cityid";

                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }

            }
        }

        enum category { student,it_professional}
        enum gender { male,female,other}

        category cat;
        gender gen;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                MessageBox.Show("Full Name can't be blank");
            }
            else
            {
                if(radioButton1.Checked)
                {
                    cat=category.student;
                }
                else if(radioButton2.Checked)
                {
                    cat = category.it_professional;
                }
                MessageBox.Show("Category: " + cat);

                if(radioButton3.Checked)
                {
                    gen=gender.male;
                }
                else if( radioButton4.Checked)
                {
                    gen=gender.female;
                }
                else if(radioButton5.Checked) 
                {
                    gen=gender.other;
                }
                MessageBox.Show("Gender is " + gen);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                cat = category.student;
                textBox2.Text = "1000";
                textBox3.Text = "0";
                textBox4.Text = "0";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                cat = category.it_professional;
                textBox2.Text = "3000";
                textBox3.Text = "0";
                textBox4.Text = "0";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            calculatefees();
        }

        public void calculatefees()
        {
            if(cat.ToString()=="student")
            {
                textBox2.Text = "1000";

                float ta=Convert.ToSingle(textBox2.Text);
                float fp = 0.5f * ta;
                float amt=Convert.ToSingle(textBox3.Text);

                if(amt<fp)
                {
                    MessageBox.Show("Minimum amount paid should be 50% of total amount");
                }
                else
                {
                    float bamt = ta - amt;
                    textBox4.Text=bamt.ToString();
                }

            }
            else if (cat.ToString() == "it_professional")
            {
                textBox2.Text = "3000";

                float ta = Convert.ToSingle(textBox2.Text);
                float fp = 0.8f * ta;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("Minimum amount paid should be 80% of total amount");
                }
                else
                {
                    float bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }

            }
        }

    }
}
