using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Asp.net2
{
    public partial class Course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (RadioButton4.Checked)
            {
                TextBox3.Text = "1000";
            }
            
        }
        enum category { student, itproffesional };

        category c;
        double fp, ta, amt, bamt;

        protected void RadioButton4_CheckedChanged1(object sender, EventArgs e)
        {
            if (RadioButton4.Checked)
            {
                c = category.student;
                TextBox3.Text = "";
                TextBox3.Text = "1000";
                TextBox4.Text = "0";
                TextBox5.Text = "0";
            }
        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton5.Checked)
            {
                c = category.itproffesional;
                TextBox3.Text = "";
                TextBox3.Text = "3000";
                TextBox4.Text = "0";
                TextBox5.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Full Name: " + TextBox1.Text + "<br>");

            string g = null;
            if(RadioButton1.Checked)
            {
                g=RadioButton1.Text;
            }
            else if(RadioButton2.Checked)
            {
                g=RadioButton2.Text;
            }
            else if(RadioButton3.Checked)
            {
                g=RadioButton3.Text;
            }
            sb.Append("Gender: " + g + "<br>");

            string category = null;
            if(RadioButton4.Checked)
            {
                category = RadioButton4.Text;
            }
            else if(RadioButton5.Checked)
            {
                category = RadioButton5.Text;
            }

            sb.Append("Country: " + DropDownList1.Text+"<br>");
            sb.Append("State: " + DropDownList2.Text + "<br>");
            sb.Append("City: " + DropDownList3.Text + "<br>");

            sb.Append("Date: " + TextBox2.Text + "<br>");
            sb.Append("Total Amount: " + TextBox3.Text + "<br>");
            sb.Append("Fees paid: " + TextBox4.Text + "<br>");
            sb.Append("Balance Amount: " + TextBox5.Text);
            Label1.Text = sb.ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = DropDownList1.Text;
            DropDownList2.Items.Clear();
            switch (c)
            {
                case "India":
                    DropDownList2.Items.Add("Maharashtra");
                    DropDownList2.Items.Add("MP");
                    break;
                case "USA":
                    DropDownList2.Items.Add("Newyork");
                    DropDownList2.Items.Add("California");
                    break;
            }
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList2_SelectedIndexChanged1(object sender, EventArgs e)
        {
            string c1 = DropDownList2.Text;
            DropDownList3.Items.Clear();
            switch (c1)
            {
                case "Maharashtra":
                    DropDownList3.Items.Add("Nagpur");
                    DropDownList3.Items.Add("Mumbai");
                    break;
                case "MP":
                    DropDownList3.Items.Add("Delhi");
                    DropDownList3.Items.Add("Bihar");
                    break;
                case "Newyork":
                    DropDownList3.Items.Add("White house");
                    DropDownList3.Items.Add("Shine");
                    break;
                case "California":
                    DropDownList3.Items.Add("White");
                    DropDownList3.Items.Add("abc");
                    break;
            }
        }
        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            if(c==category.student)
            {
                ta=Convert.ToDouble(TextBox3.Text);
                fp = ta * 0.5f;
                amt =Convert.ToDouble(TextBox4.Text);
                if (amt < fp)
                {
                    Response.Write("Minimum amount to be 50%");
                    TextBox5.Text = "0";
                }
                else
                {
                    bamt = ta - amt;
                    TextBox5.Text = bamt.ToString();
                }
            }
            else if (c == category.itproffesional)
            {
                ta = Convert.ToDouble(TextBox3.Text);
                fp = ta * 0.8f;
                amt = Convert.ToDouble(TextBox4.Text);
                if (amt < fp)
                {
                    Response.Write("Minimum amount to be 80%");
                    TextBox5.Text = "0";
                }
                else
                {
                    bamt = ta - amt;
                    TextBox5.Text = bamt.ToString();

                }
            }
        }
    }
}