using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_customer_products
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            switch(comboBox1.Text)
            {
                case "Electronics":
                    comboBox2.Items.Add("Laptop");
                    comboBox2.Items.Add("Fan");
                    comboBox2.Items.Add("Ac");
                    comboBox2.Items.Add("Washing Machine");
                    comboBox2.Items.Add("LED TV");
                    comboBox2.Items.Add("Fridge");
                    break;

                case "Furniture":
                    comboBox2.Items.Add("Bed");
                    comboBox2.Items.Add("Sofa");
                    comboBox2.Items.Add("Dressing Table");
                    comboBox2.Items.Add("Study Table");
                    comboBox2.Items.Add("Sofa cum Bed");
                    break;

                case "Sports":
                    comboBox2.Items.Add("Cricket Products");
                    comboBox2.Items.Add("Bascket Ball Products");
                    comboBox2.Items.Add("Volley Ball Products");
                    comboBox2.Items.Add("Badbinton Products");
                    break;
                case "Household":
                    comboBox2.Items.Add("Utensils");
                    comboBox2.Items.Add("Curtains");
                    comboBox2.Items.Add("Bedsheets");
                    comboBox2.Items.Add("Flower vase");
                    comboBox2.Items.Add("Mat");
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb= new StringBuilder();
            if(textBox1.Text=="" && textBox2.Text=="" && textBox3.Text=="")
            {
                MessageBox.Show("Please Enter Details: ");
            }
            else
            {
                sb.Append("Name: " + textBox1.Text +"\n");
                sb.Append("Phone no: " + maskedTextBox1.Text + "\n");
                sb.Append("Products: " + comboBox1.Text + "\n");
                sb.Append("Items: " + comboBox2.Text + "\n");
                int quantity = Convert.ToInt32(textBox2.Text);
                sb.Append("Quantity: " + quantity + "\n");
                int price=Convert.ToInt32(textBox3.Text);
                sb.Append("Price: " + price + "\n");
                int total = quantity * price;
                sb.Append("Total Price: "+total+ "\n");
                label8.Text = sb.ToString();
            }
        }
    }
}
