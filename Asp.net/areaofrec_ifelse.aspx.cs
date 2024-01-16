using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp.net
{
    public partial class areaofrec_ifelse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            decimal l = Convert.ToDecimal(TextBox1.Text);
            decimal b = Convert.ToDecimal(TextBox2.Text);
            decimal res = l * b;
            Label1.Text = "Area of Rectangle : " + res;
        }
    }
}