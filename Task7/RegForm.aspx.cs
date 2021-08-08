using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class RegForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ArrayList ar = new ArrayList();
            ar.Add(TextBox1.Text);
            ar.Add(TextBox2.Text);
            if (RadioButton1.Checked == true)
            {
                ar.Add("Male");
            }
            if (RadioButton2.Checked == true)
            {
                ar.Add("Female");
            }
            if (RadioButton3.Checked == true)
            {
                ar.Add("Others");
            }
            if (RadioButton4.Checked == true)
            {
                ar.Add("UnMarried");
            }
            if (RadioButton5.Checked == true)
            {
                ar.Add("Married");
            }
            if (RadioButton6.Checked == true)
            {
                ar.Add("Divorced");
            }


            ar.Add(TextBox3.Text);
            ar.Add(TextBox4.Text);
            ar.Add(TextBox5.Text);
            ar.Add(TextBox6.Text);
            
           foreach (ListItem AR in CheckBoxList1.Items)
            {
                if (AR.Selected == true)
                   ar.Add(AR.Text);

            }
            FileStream fs = new FileStream("E:\\Training\\Details.txt", FileMode.OpenOrCreate,FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            foreach (string s in ar)
            {
                sw.Write(s + "\n");
            }
            sw.Flush();
            sw.Close();
            fs.Close();
            Response.Redirect("Details.aspx");

        }
    }
}