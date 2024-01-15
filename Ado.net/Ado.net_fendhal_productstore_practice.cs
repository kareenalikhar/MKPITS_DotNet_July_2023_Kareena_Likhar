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

namespace Ado.net_fendhal_productstore_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        string strcon = "server=HP\\SQLEXPRESS;integrated security=true;database=ProductStore;";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        private void Form1_Load(object sender, EventArgs e)
        {
            productcategory();
            product();
            getprice();
        }
        public void productcategory()
        {
            try
            {
                con=new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableProductCategory", con);
                ds = new DataSet();
                da.Fill(ds,"productcategory");
                comboBox1.DataSource = ds.Tables["productcategory"];
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
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            product();
        }

        public void getprice()
        {
            if(comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con=new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableProduct where ProductID=@ProductID", con);
                    da.SelectCommand.Parameters.AddWithValue("@ProductID", comboBox2.SelectedValue);
                    ds = new DataSet();
                    da.Fill(ds, "price");
                    foreach(DataRow dr in ds.Tables["price"].Rows)
                    {
                        textBox9.Text = dr["ProductPrice"].ToString();
                    }
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getprice();
        }
    }
}
