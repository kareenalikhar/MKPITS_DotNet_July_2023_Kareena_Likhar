using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net
{
    public partial class calculation_switch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num1=Convert.ToInt32(TextBox1.Text);
            int num2=Convert.ToInt32(TextBox2.Text);
            char op=Convert.ToChar(TextBox3.Text);
            int res = 0;
            switch(op)
            {
                case '+':
                res=num1 + num2;
                    break;
                case '-':
                    res = num1 - num2;
                    break;
                case '*':
                    res = num1 * num2;
                    break;
                case '/':
                    res = num1 / num2;
                    break;
                default:
                    Response.Write( "Invalid Operator");
                    break;
            }
            Label1.Text = "Result: " + res;
        }
    }
}