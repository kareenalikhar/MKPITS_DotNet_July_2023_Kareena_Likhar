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

namespace ado.net_employee_company
{
    public partial class Form1 : Form
    {
        public string str = "server=HP\\SQLEXPRESS;integrated security=true;database=Company";
       
        SqlDataAdapter sqlda;
        DataSet dataset;
        SqlCommandBuilder cb;
        public Form1()
        {
            InitializeComponent();
            sqlda = new SqlDataAdapter("select * from employee",str);
            cb=new SqlCommandBuilder(sqlda);
            dataset = new DataSet();
            sqlda.Fill(dataset, "Emp");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //create
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = dataset.Tables["Emp"].NewRow();
            dr[0] = textBox1.Text;
            dr[1]=textBox2.Text;
            dr[2]=textBox3.Text;
            dr[3]=Convert.ToInt32(textBox4.Text);
            dr[4]=textBox5.Text;
            dr[5]=textBox6.Text;
            dr[6]=Convert.ToInt32(textBox7.Text);

            dataset.Tables["Emp"].Rows.Add(dr);

            sqlda.Update(dataset.Tables["Emp"]);
            MessageBox.Show("Data Successfully inserted");
        }

        //select
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataset.Tables["Emp"];
        }

        //update
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dataset.Tables["Emp"].Rows)
            {
                if (dr[0].ToString() ==textBox1.Text)
                {
                    try
                    {
                        dr[0] = textBox1.Text;
                        dr[1] = textBox2.Text;
                        dr[2] = textBox3.Text;
                        dr[3] = Convert.ToInt32(textBox4.Text);
                        dr[4] = textBox5.Text;
                        dr[5] = textBox6.Text;
                        dr[6] = Convert.ToInt32(textBox7.Text);
                        sqlda.Update(dataset.Tables["Emp"]);
                        MessageBox.Show("Data Successfully Updated");

                    }
                    catch(Exception ee)
                    {
                        MessageBox.Show(ee.ToString());
                    }
                    break;
                }
            }
        }

        //delete
        private void button4_Click(object sender, EventArgs e)
        {
            int intCounter = 0;
            DataRow drTarget;
            foreach (DataRow dr in dataset.Tables["Emp"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        //dataSet.Tables["Emp"].Rows.Remove(dr);
                        //dr.Delete();
                        //Sqlda.Update(dataSet.Tables["Emp"]);
                        dr.Delete();
                        // No need to call Rows.Remove(dr) if you are using dr.Delete()

                        sqlda.Update(dataset.Tables["Emp"]);
                        dataset.Tables["Emp"].AcceptChanges();
                        MessageBox.Show("Data Successfully Deleted..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0,e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1,e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2,e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3,e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4,e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5,e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6,e.RowIndex].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4 .Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
