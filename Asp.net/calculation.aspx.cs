﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net
{
    public partial class calculation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1=Convert.ToInt32(TextBox1.Text);
            int num2=Convert.ToInt32(TextBox2.Text);
            int res = 0;
            char op=Convert.ToChar(TextBox3.Text);
            if(op =='+')
            {
                res=num1 + num2;
                Label1.Text = "Addition: " + res;
            }
            else if (op == '-')
            {
                res = num1 - num2;
                Label1.Text = "Substraction: " + res;
            }
            else if (op == '*')
            {
                res = num1 * num2;
                Label1.Text = "Multiplication: " + res;
            }
            else if (op == '/')
            {
                res = num1 / num2;
                Label1.Text = "Division: " + res;
            }
            else
            {
                Label1.Text = "Invalid Operator";
            }
        }
    }
}