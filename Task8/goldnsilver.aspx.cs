using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class goldnsilver : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HiddenField1.Value = "10g of 24k gold (99.9%) in Chennai is 47,980.00 Indian Rupee";
            HiddenField2.Value = "10g of 24k silver (99.9%) in Chennai is 621.00 Indian Rupee";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = HiddenField1.Value.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox2.Text = HiddenField2.Value.ToString();
        }
    }
}