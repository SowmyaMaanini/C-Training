using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Breakfast")
            {
                Response.Redirect("Breakfast.aspx");
            }
            if (DropDownList1.SelectedValue == "Lunch")
            {
                Response.Redirect("Lunch.aspx");
            }
            if (DropDownList1.SelectedValue == "Snacks")
            {
                Response.Redirect("Snacks.aspx");
            }


        }
    }
}