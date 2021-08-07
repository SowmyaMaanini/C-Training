using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button3.Attributes.Add("onclick", "return false");
            if (DropDownList1.SelectedValue == "California")
            {
                
                DropDownList2.Items.Add("Los Angeles");
                DropDownList2.Items.Add("San Francisco");

            }
            else if (DropDownList1.SelectedValue == "Texas")
            {
                DropDownList2.Items.Add("Dallas");
                DropDownList2.Items.Add("Houston");

            }
            else if (DropDownList1.SelectedValue == "Florida")
            {
                DropDownList2.Items.Add("Miami");
                DropDownList2.Items.Add("Key West");

            }
            else if (DropDownList1.SelectedValue == "New Jersy")
            {
                DropDownList2.Items.Add("Atlantic City");
                DropDownList2.Items.Add("Cape May");

            }
            else if (DropDownList1.SelectedValue == "Hawai")
            {
                DropDownList2.Items.Add("Hilo");
                DropDownList2.Items.Add("Hawi");

            }
        }
    }
}