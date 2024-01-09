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
            dateTimePicker1.Text=DateTime.Now.ToShortDateString();
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

        public enum category { student,it_professional}
        public enum gender { male,female,other}

        category cat;
        gender gen;
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            if(selectedDate.Date<DateTime.Today)
            {
                MessageBox.Show("Please select a payment date that is on or after today's date", "Invalid date selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


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

                savecourseregdetail(cat, gen);
            }
        }

        public void savecourseregdetail(category c,gender g)
        {
            try
            {
                string str = "insert into tablecourseregdetail values(@categoryid,@fullname,@genderid)";
                SqlCommand command = new SqlCommand(str, con);
                command.Parameters.AddWithValue("@categoryid", c);
                command.Parameters.AddWithValue("@fullname", textBox1.Text);
                command.Parameters.AddWithValue("@genderid", g);
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                insertRegAddress();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void insertRegAddress()
        {
            con.Open();

            string str = "select max(courseregid) from tablecourseregdetail";
            SqlCommand cmd11 = new SqlCommand(str, con);
            int mcid = Convert.ToInt32(cmd11.ExecuteScalar());
            string s2 = "insert into TableRegAddress values(@CourseRegID,@NationID,@StateID,@CityID)";
            SqlCommand cmd1 = new SqlCommand(s2, con);
            cmd1.Parameters.AddWithValue("@CourseRegID", mcid);
            cmd1.Parameters.AddWithValue("@NationID", comboBox1.SelectedValue);
            cmd1.Parameters.AddWithValue("@StateID", comboBox2.SelectedValue);
            cmd1.Parameters.AddWithValue("@CityID", comboBox3.SelectedValue);
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Stored TableRegAddress");
            con.Close();
          
            insertFeeDetail();
        }

        public void insertFeeDetail()
        {
            con.Open();
            string str = "select max(courseregid) from tablecourseregdetail";
            SqlCommand cmd = new SqlCommand(str, con);
            int mcid= Convert.ToInt32(cmd.ExecuteScalar());

            string s2 = "insert into tablefeedetail values(@courseregid,@totalamount,@minper,@paidamount,@balamount,@paiddate)";
            SqlCommand cmd1=new SqlCommand(s2, con);
            cmd1.Parameters.AddWithValue("@courseregid", mcid);
            cmd1.Parameters.AddWithValue("@totalamount",textBox2.Text);
            cmd1.Parameters.AddWithValue("@MinPer", fp);
            cmd1.Parameters.AddWithValue("@paidamount",textBox3.Text);
            cmd1.Parameters.AddWithValue("@balamount", textBox4.Text);
            cmd1.Parameters.AddWithValue("@paiddate", dateTimePicker1.Value);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Stored Tablefeedetail");
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

        float fp=0;
        float bamt=0;
        public void calculatefees()
        {
            if(cat.ToString()=="student")
            {

                float ta=Convert.ToSingle(textBox2.Text);
                fp = 0.05f * ta;
                float amt=Convert.ToSingle(textBox3.Text);

                if(amt<fp)
                {
                    MessageBox.Show("Minimum amount paid should be 50% of total amount");
                }
                else
                {
                    bamt = ta - amt;
                    textBox4.Text=bamt.ToString();
                }

            }
            else if (cat.ToString() == "it_professional")
            {

                float ta = Convert.ToSingle(textBox2.Text);
                fp = 0.8f * ta;
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

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            getnation();
            getstate();
            getcity();
            radioButton1.Checked = true;
            radioButton2.Checked=false;
            radioButton3.Checked=true;
            radioButton4.Checked=false;
            radioButton5.Checked=false;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text=string.Empty;
            textBox2.Text=string.Empty;
            textBox3.Text=string.Empty;
            textBox4.Text = string.Empty;
            dateTimePicker1.Text=DateTime.Now.ToString();
        }
    }
}
