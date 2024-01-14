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

namespace Ado.net_fendhal_product_store
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public enum nationality { indian, NRI };
        nationality nat;
        string strcon = "server=HP\\SQLEXPRESS;integrated security=true;database=ProductStore;";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        private void Form1_Load(object sender, EventArgs e)
        {
            productcategory();
            product();
            getprice();
            nat = nationality.indian;
        }

        public void productcategory()
        {
            try
            {
                con=new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableProductCategory", con);
                ds= new DataSet();
                da.Fill(ds, "productcat");
                comboBox1.DataSource = ds.Tables["productcat"];
                comboBox1.DisplayMember = "Product_Type_Name";
                comboBox1.ValueMember = "Product_Category_ID";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void product()
        {
            if(comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableProduct where Product_Category_ID=@Product_Category_ID", con);
                    da.SelectCommand.Parameters.AddWithValue("@Product_Category_ID", comboBox1.SelectedValue);
                    ds = new DataSet();
                    da.Fill(ds, "product");
                    comboBox2.DataSource = ds.Tables["product"];
                    comboBox2.DisplayMember = "Product_Name";
                    comboBox2.ValueMember = "ProductID";
                }
                catch(SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox4.Text = "0";
            product();
            if (comboBox1.Text != "System.Data.DataRowView")
            {
                try
                {
                    string catname = comboBox1.Text;
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableProductGSTDetails where GST_Detail_Name=@gdn", con);
                    da.SelectCommand.Parameters.AddWithValue("@gdn", catname);
                    ds = new DataSet();
                    da.Fill(ds, "tgst");
                    foreach (DataRow dr in ds.Tables["tgst"].Rows)
                    {
                        textBox7.Text = dr["cgst"].ToString();
                        textBox8.Text = dr["sgst"].ToString();
                        textBox9.Text = dr["igst"].ToString();
                    }
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0";
            textBox4.Text = "0";
            getprice();

        }

        public void getprice()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableProduct where ProductID=@ProductID", con);
                    da.SelectCommand.Parameters.AddWithValue("@ProductID", comboBox2.SelectedValue);
                    ds = new DataSet();
                    da.Fill(ds, "product1");
                    foreach(DataRow dr in ds.Tables["product1"].Rows)
                    {
                        textBox3.Text = dr["productprice"].ToString();
                    }                   
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Enter Only Numbers");
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            if(selectedDate.Date < DateTime.Today)
            {
                MessageBox.Show("Please select a Payment Date that is on or after today's date");
                return;
            }

            if(textBox1.Text=="" && textBox2.Text=="")
            {
                MessageBox.Show("You cannot left any field blank");
            }
            else
            {
                SqlConnection con = new SqlConnection(strcon);
                con.Open();
                string str = "insert into TableInvoiceDetails values(@Customer_Name,@Customer_Contact,@Product_Category_ID,@ProductID,@Residential_Type_ID,@Invoice_Date,@Quantity,@Price,@CGST,@SGST,@IGST,@CGST_Value,@SGST_Value,@IGST_Value,@Total_Amount)";
                SqlCommand cmd= new SqlCommand(str, con);
                cmd.Parameters.AddWithValue("@Customer_Name", textBox1.Text);
                cmd.Parameters.AddWithValue("Customer_Contact", textBox2.Text);
                cmd.Parameters.AddWithValue("@Product_Category_ID", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@ProductID", comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("@Residential_Type_ID", 1001);
                cmd.Parameters.AddWithValue("@Invoice_Date", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Quantity", textBox4.Text);
                cmd.Parameters.AddWithValue("@Price", textBox3.Text);
                cmd.Parameters.AddWithValue("@CGST", textBox7.Text);
                cmd.Parameters.AddWithValue("@SGST", textBox8.Text);
                cmd.Parameters.AddWithValue("@IGST", textBox9.Text);
                cmd.Parameters.AddWithValue("@CGST_Value", textBox10.Text);
                cmd.Parameters.AddWithValue("@SGST_Value", textBox11.Text);
                cmd.Parameters.AddWithValue("@IGST_Value", textBox12.Text);
                cmd.Parameters.AddWithValue("@Total_Amount", textBox6.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Invoice Record inserted Successfully");

            }
            Clear();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                nat = nationality.indian;
                textBox4.Text = "0";
                textBox5.Text="0";
                textBox6.Text="0";
                textBox10.Text="0";
                textBox11.Text="0";
                textBox12.Text="0";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                nat = nationality.NRI;
                textBox4.Text = "0";
                textBox5.Text = "0";
                textBox6.Text = "0";
                textBox10.Text = "0";
                textBox11.Text = "0";
                textBox12.Text = "0";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if(textBox4.Text != "")
            {
                double price=Convert.ToDouble(textBox3.Text);
                double quantity=Convert.ToDouble(textBox4.Text);
                double totalamount=price*quantity;
                textBox5.Text = totalamount.ToString();
                double gst = Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox7.Text) / 100;
                if (nat.ToString()== "indian")
                {
                    textBox10.Text = gst.ToString();
                    textBox11.Text = gst.ToString();
                    textBox12.Text = "0";
                    double netamt = Convert.ToDouble(textBox10.Text) + Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox5.Text);
                    textBox6.Text = netamt.ToString();
                }
                else if (nat.ToString() == "NRI")
                {
                    textBox10.Text = "0";
                    textBox11.Text = "0";
                    textBox12.Text = gst.ToString();
                    double netamt = Convert.ToDouble(textBox12.Text) + Convert.ToDouble(textBox5.Text);
                    textBox6.Text = netamt.ToString();
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {            
                   
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
            comboBox1.Text = "select";
            comboBox2.Text= "select";
            dateTimePicker1.Value= DateTime.Now;

        }
    }
}
