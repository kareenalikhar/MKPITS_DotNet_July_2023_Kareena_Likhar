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

namespace ado.net_course_reg_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string strcon = "server=HP\\SQLEXPRESS;integrated security=true;database=CourseTest;";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToString();
            getNation();
            getState();
            getCity();
            if(radioButton1.Checked)
            {
                textBox2.Text = "1000";
            }
        }

        public void getNation()
        {
            try
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from tablenation", con);
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
        public void getState()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from tablestate where nationid=@nationid", con);
                    da.SelectCommand.Parameters.AddWithValue("@nationid", comboBox1.SelectedValue);
                    ds = new DataSet();
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
        public void getCity()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from tablecity where stateid=@stateid", con);
                    da.SelectCommand.Parameters.AddWithValue("@stateid", comboBox2.SelectedValue);
                    ds = new DataSet();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getState();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCity();
        }


        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public enum Category { student,it_professional};
        public enum Gender { male,female,other};

        Category cat;
        Gender gen;
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;

            if(selectedDate.Date < DateTime.Today)
            {
                MessageBox.Show("Date should be present or future not past");
            }

            if(textBox1.Text=="")
            {
                MessageBox.Show("Full Name not be blank");
            }
            else
            {
                if(radioButton1.Checked)
                {
                    cat=Category.student;
                }
                else if(radioButton2.Checked)
                {
                    cat=Category.student;
                }
                MessageBox.Show("Category : " + cat);

                if(radioButton3.Checked)
                {
                    gen=Gender.male;
                }
                else if( radioButton4.Checked)
                {
                    gen=Gender.female;
                }
                else if(radioButton5.Checked)
                {
                    gen = Gender.other;
                }
                MessageBox.Show("Gender: " + gen);
                saveCourseRegdetail(cat, gen);
            }

        }
        public void saveCourseRegdetail(Category c,Gender g)
        {
            try
            {
                string str = "insert into TableCourseRegDetail values(@categoryid,@fullname,@genderid)";
                SqlCommand command = new SqlCommand(str, con);
                command.Parameters.AddWithValue("@categoryid", Convert.ToInt32(c));
                command.Parameters.AddWithValue("@fullname", textBox1.Text);
                command.Parameters.AddWithValue("@genderid", Convert.ToInt32(g));
                con.Open();
                command.ExecuteNonQuery();
                con.Close();
                insertRegAddress();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        public void insertRegAddress()
        {
            try
            {
                con.Open();
                string str = "select max(courseregid) from TableCourseRegDetail ";
                SqlCommand command = new SqlCommand(str, con);
                int mcid=Convert.ToInt32(command.ExecuteScalar());
                string s = "insert into TableRegAddress values(@courseregid,@nationid,@stateid,@cityid)";
                SqlCommand cmd=new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@courseregid", mcid);
                cmd.Parameters.AddWithValue("@nationid", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@stateid", comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("@cityid", comboBox3.SelectedValue);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Stored TableRegAddress");
                insertFeesDetail();
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        public void insertFeesDetail()
        {
            try
            {
                con.Open();
                string str = "select max(courseregid) from TableCourseRegDetail";
                SqlCommand command = new SqlCommand(str, con);
                int mcid = Convert.ToInt32(command.ExecuteScalar());
                string s = "insert into TableFeeDetail values(@courseregid,@TotalAmount,@MinPer,@PaidAmount,@BalAmount,@PaidDate)";
                SqlCommand cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@courseregid", mcid);
                cmd.Parameters.AddWithValue("@TotalAmount", textBox2.Text);
                cmd.Parameters.AddWithValue("@MinPer", fp);
                cmd.Parameters.AddWithValue("@PaidAmount", textBox3.Text);
                cmd.Parameters.AddWithValue("@BalAmount", textBox4.Text);
                cmd.Parameters.AddWithValue("@PaidDate", dateTimePicker1.Value);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Stored TableFeeDetail");

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            
        }

        float fp=0;
        float bamt=0;
        public void calculatefees()
        {
            if(cat.ToString()=="student")
            {

                float ta=Convert.ToSingle(textBox2.Text);
                fp = ta*0.5f;
                float amt = Convert.ToSingle(textBox3.Text);

                if(amt < fp)
                {
                    MessageBox.Show("Paid atleast 50% of total amount");
                }
                else
                {
                    bamt = ta - amt;
                    textBox4.Text=bamt.ToString();
                }

            }
            else if(cat.ToString()=="it_professional")
            {

                float ta = Convert.ToSingle(textBox2.Text);
                fp =  ta * 0.8f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("Paid atleast 80% of total amount");
                }
                else
                {
                    bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                cat = Category.student;
                textBox2.Text = "1000";
                textBox3.Text = "0";
                textBox4.Text = "0";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cat = Category.it_professional;
                textBox2.Text = "3000";
                textBox3.Text = "0";
                textBox4.Text = "0";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            calculatefees();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
        public void clear()
        {
            getNation();
            getState();
            getCity();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = true;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            dateTimePicker1.Text = DateTime.Now.ToString();

        }
    }
}
